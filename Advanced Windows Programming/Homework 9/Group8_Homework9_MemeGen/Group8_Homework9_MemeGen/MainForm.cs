using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MarkdownSharp;
using System.Runtime.Serialization.Formatters.Binary;

namespace Group8_Homework9_MemeGen
{
    public partial class MainForm : Form
    {
        private Document document;
        private Markdown md;
        private BindingSource bindingSource;
        private int lastScrollTop = 0;
        private static string defaultFileName = "New Document";
        private static string appName = "JotDown";
        private static string htmlTemplate = "<html><head><style type='text/css'>{0}</style></head><body>{1}</body></html>";

        private bool preview = false;
        private int m_nTotalPage = 0;
        private string stringToPrint;
        private bool realPrint = false;
        private string[] pages = new string[1000];
        private int m_nPage = 0;
        private int m_nMaxPage;

        public MainForm()
        {
            InitializeComponent();
            this.splitContainer.SplitterDistance = this.Size.Width / 2;
            resizeControls();
            this.document = new Document();
            this.md = new Markdown();
            this.bindingSource = new BindingSource(this.document, "");
            this.richTextBox.DataBindings.Add("Text", this.bindingSource, "Content", true, DataSourceUpdateMode.OnPropertyChanged);
            this.richTextBox.DataBindings.Add("BackColor", this.bindingSource, "LeftPanelBackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            this.richTextBox.DataBindings.Add("Font", this.bindingSource, "LeftPanelFont", true, DataSourceUpdateMode.OnPropertyChanged);
            this.richTextBox.DataBindings.Add("ForeColor", this.bindingSource, "LeftPanelFontColor", true, DataSourceUpdateMode.OnPropertyChanged);
            this.richTextBox.AllowDrop = true;
            this.richTextBox.DragEnter += new DragEventHandler(this.richTextBox_DragEnter);
            this.richTextBox.DragDrop += new DragEventHandler(this.richTextBox_DragDrop);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayFileName(defaultFileName);
            webBrowser.Document.OpenNew(true);
        }

        private void DisplayFileName(string fileName)
        {
            this.Text = fileName + " - " + appName;
        }


        private void resizeControls() {
            
            this.richTextBox.Width = this.splitContainer.Panel1.ClientSize.Width;
            this.richTextBox.Height = this.splitContainer.Panel1.ClientSize.Height;

        }

        private void splitContainer_Panel1_SizeChanged(object sender, EventArgs e)
        {
            resizeControls();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "*";
                saveFileDialog.DefaultExt = "jd";
                saveFileDialog.Filter = "JotDown File (*.jd) | *.jd|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    string ext = Path.GetExtension(fileName);

                    if (ext == ".jd")
                    {
                        this.document.Save(fileName);
                        DisplayFileName(fileName);
                    }
                    else if (ext == ".md" || ext == ".txt")
                        this.richTextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    else if (ext == ".rtf")
                        this.richTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
                    else
                    {
                        this.document.Save(fileName);
                        DisplayFileName(fileName);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            this.Close();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.document.FileName != null)
                this.document.Save(document.FileName);
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = "*";
                openFileDialog.DefaultExt = "jd";
                openFileDialog.Filter = "JotDown File (*.jd) | *.jd|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.document = Document.Open(openFileDialog.FileName);                   
                    this.bindingSource.DataSource = this.document;
                    DisplayFileName(document.FileName);
                }
            }
        }

        private void richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            int i;
            String s;

            i = richTextBox.SelectionStart;
            s = richTextBox.Text.Substring(i);
            richTextBox.Text = richTextBox.Text.Substring(0, i);

            richTextBox.Text = richTextBox.Text +
               e.Data.GetData(DataFormats.Text).ToString();
            richTextBox.Text = richTextBox.Text + s;


        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle realPageBounds = PrintBounds.GetRealPageBounds(e, preview);
            Rectangle realMarginBounds = PrintBounds.GetRealMarginBounds(e, preview);
            int charactersOnPage = 0;
            int linesPerPage = 0;
            
            if (!realPrint)
            { 
                g.MeasureString(stringToPrint, this.richTextBox.Font, realMarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
                g.DrawString(stringToPrint, this.richTextBox.Font, Brushes.Black, realMarginBounds, StringFormat.GenericTypographic);
                pages[m_nPage] = stringToPrint.Substring(0, charactersOnPage);         
                stringToPrint = stringToPrint.Substring(charactersOnPage);
                m_nPage++;
                e.HasMorePages = (stringToPrint.Length > 0);
            }
            else
            {
                g.MeasureString(pages[m_nPage], this.richTextBox.Font, realMarginBounds.Size, StringFormat.GenericTypographic);
                g.DrawString(pages[m_nPage], this.richTextBox.Font, Brushes.Black, realMarginBounds, StringFormat.GenericTypographic);
                m_nPage++;
                e.HasMorePages = (m_nPage + 1 ) <= m_nMaxPage;
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            preview = (e.PrintAction == PrintAction.PrintToPreview);
            stringToPrint = this.richTextBox.Text;
        }

        private void updateRightPanel()
        {
            this.webBrowser.DocumentText = String.Format(htmlTemplate, this.document.Style, this.md.Transform(this.richTextBox.Text));
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            updateRightPanel();

            updateLineCount();
            updateFontStatus();
            updateWordCount();
        }

        //Methods to update status bar
        private void updateLineCount()
        {
            var lineCount = richTextBox.Lines.Count();
            toolStripStatusLabel1.Text = string.Format("Lines: {0}", lineCount);
            statusStrip.Refresh();
        }

        private void updateFontStatus()
        {
            toolStripStatusLabel3.Text = string.Format("Font: {0}  Size: {1} ", richTextBox.Font.Name.ToString(), richTextBox.Font.Size.ToString());
            statusStrip.Refresh();
        }

        private void updateWordCount()
        {
            var text = richTextBox.Text.Trim();
            int wordCount = 0;
            int index = 0; //need this to parse string

            while(index < text.Length)
            {
                while(index < text.Length && !char.IsWhiteSpace(text[index]))
                {
                    index++;
                }

                wordCount++;

                while(index < text.Length && char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
            }

            toolStripStatusLabel2.Text = string.Format("Words: {0}", wordCount);
            statusStrip.Refresh();
        }

        private void loadCustomCSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    this.document.Style = Document.LoadCSS(openFileDialog.FileName);
        }

        private void reloadDefaultCSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.document.LoadDefaultCSS();
        }

        private Object DeepClone(Object obj)
        {
            using (MemoryStream buffer = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(buffer, obj);
                buffer.Position = 0;
                object temp = formatter.Deserialize(buffer);
                return temp;
            }
        }

        private void OpenPreferencesDialog()
        {
            Document savedDocument = DeepClone(this.document) as Document;

            using (Form preferencesDialog = new PreferencesDialog(this.bindingSource))
                if (preferencesDialog.ShowDialog() == DialogResult.Cancel)
                    this.bindingSource.DataSource = savedDocument;
        }


        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPreferencesDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDialog search = new SearchDialog();
            search.Accept += Properties_AcceptSearch;
            search.Double_Click += AddFile_DoubleClick;
            search.Show();
            searchToolStripMenuItem.Enabled = false;
        }

        void Properties_AcceptSearch(object sender, EventArgs e)
        {
            SearchDialog form = (SearchDialog)sender;
            searchToolStripMenuItem.Enabled = true;
        }

        private void AddFile_DoubleClick(object sender, EventArgs e)
        {
            ImportText((sender as SearchDialog).FileText);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_nTotalPage = PageCountPrintController.GetPageCount(this.printDocument);
            m_nPage = 0;
            realPrint = true;

            printDocument.PrinterSettings.FromPage = 1;
            printDocument.PrinterSettings.ToPage = m_nTotalPage;
            printDocument.PrinterSettings.MinimumPage = 1;
            printDocument.PrinterSettings.MaximumPage = m_nTotalPage;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {             
                if (printDialog.PrinterSettings.PrintRange ==
                    PrintRange.SomePages)
                {
                    m_nPage = printDocument.PrinterSettings.FromPage - 1;
                    m_nMaxPage = printDocument.PrinterSettings.ToPage;
                }
                else
                {
                    m_nPage = 0;
                    m_nMaxPage = m_nTotalPage;
                }
                this.printDocument.Print();
            }

            realPrint = false;
        }
    

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
            richTextBox.SelectedText = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OathDialog().ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private int GetScrollTop()
        {
            if (webBrowser.Document != null)
                try
                {
                    return webBrowser.Document.Body.ScrollTop;
                } catch(Exception e)
                {
                    return 0;
                }
            return 0;

        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.lastScrollTop = GetScrollTop();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //MessageBox.Show("" + this.lastScrollTop);
            webBrowser.Document.Window.ScrollTo(new Point(0, this.lastScrollTop));
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }

        private void ImportText(string text)
        {
            this.richTextBox.Text += "\n" + text;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FileName = "*";
                openFileDialog.DefaultExt = "jd";
                openFileDialog.Filter = "Text Files (*.txt) | *.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                        ImportText(streamReader.ReadToEnd());
            }      
        }

        private void resetSplitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.splitContainer.SplitterDistance = this.splitContainer.Width / 2;
        }
    }
}
