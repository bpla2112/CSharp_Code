using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using MarkdownSharp;
using System.Drawing;

namespace Group8_Homework9_MemeGen
{
    [Serializable]
    class Document : ISerializable, INotifyPropertyChanged
    {
        private string fileName;
        private string content;
        private string style;
        private Color leftPanelBackColor;
        private Font leftPanelFont;
        private Color leftPanelFontColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get { return fileName; }  set{ fileName = value; OnChange("FileName"); } }
        public string Content { get { return content; } set { content = value; OnChange("Content"); } }  // Markdown text.
        public string Style { get { return style; } set { style = value; OnChange("Style"); } }  // CSS.
        public Color LeftPanelBackColor { get { return leftPanelBackColor; }  set { leftPanelBackColor = value; OnChange("LeftPanelBackColor"); } }
        public Font LeftPanelFont { get { return leftPanelFont; } set { leftPanelFont = value; OnChange("LeftPanelFont"); } }
        public Color LeftPanelFontColor { get { return leftPanelFontColor; } set { leftPanelFontColor = value; OnChange("LeftPanelFontColor"); } }

        public Document()
        {
            LoadDefaultCSS();
            LoadDefaultText();
            this.LeftPanelBackColor = Color.FromArgb(50,50,50);
            this.LeftPanelFont = new Font("Consolas", 12);
            this.LeftPanelFontColor = Color.White;
        }

        public void LoadDefaultText()
        {
            this.Content = Properties.Resources.JotDownGreeting;
        }

        public Document(SerializationInfo info, StreamingContext context)
        {
            this.FileName = (string)info.GetValue("FileName", typeof(string));
            this.Content = (string)info.GetValue("Content", typeof(string));
            this.Style = (string)info.GetValue("Style", typeof(string));
            this.LeftPanelBackColor = (Color)info.GetValue("LeftPanelBackColor", typeof(Color));
            this.LeftPanelFontColor = (Color)info.GetValue("LeftPanelFontColor", typeof(Color));
            this.LeftPanelFont = (Font)info.GetValue("LeftPanelFont", typeof(Font));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FileName", this.FileName);
            info.AddValue("Content", this.Content);
            info.AddValue("Style", this.Style);
            info.AddValue("LeftPanelBackColor", this.LeftPanelBackColor);
            info.AddValue("LeftPanelFontColor", this.LeftPanelFontColor);
            info.AddValue("LeftPanelFont", this.LeftPanelFont);
        }

        public static string LoadCSS(string fileName)
        {
            using (StreamReader streamReader = new StreamReader(fileName))
                return streamReader.ReadToEnd();
        }

        public void LoadDefaultCSS()
        {
            this.Style = Properties.Resources.DefaultCSS;
        }

        public void Save(string fileName)
        {
            this.FileName = fileName;

            using (Stream stream = new FileStream(this.FileName, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }

        }

        public static Document Open(string fileName)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                return (Document)formatter.Deserialize(stream);
            }

        }

        protected void OnChange(string propName) { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propName)); }

    }
}
