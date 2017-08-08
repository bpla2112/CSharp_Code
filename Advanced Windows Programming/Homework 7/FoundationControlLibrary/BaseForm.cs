using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FoundationControlLibrary
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }



        public void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
        }

        public void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("This fearture is not supported yet.");
        }

        protected virtual void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("This fearture is not supported yet.");
        }

        private void baseMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
