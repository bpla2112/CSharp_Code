﻿using System;
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
            BaseFormContextMenuStrip.Visible = true;
        }

        Point downPoint = Point.Empty;

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            Point location = new Point(this.Left + e.X - downPoint.X,
                                       this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK )
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
