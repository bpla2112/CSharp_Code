namespace Group_8_Homework_7
{
    partial class ShapeOptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeOptionsDialog));
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.penColorPanel = new System.Windows.Forms.Panel();
            this.penColorTextBox = new System.Windows.Forms.TextBox();
            this.penGroupBox = new System.Windows.Forms.GroupBox();
            this.penStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.penColorLabel = new System.Windows.Forms.Label();
            this.brushGroupBox = new System.Windows.Forms.GroupBox();
            this.brushStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brushColorTextBox = new System.Windows.Forms.TextBox();
            this.brushColorPanel = new System.Windows.Forms.Panel();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.penStyleComboBox = new System.Windows.Forms.ComboBox();
            this.brushStyleComboBox = new System.Windows.Forms.ComboBox();
            this.shapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeLabel = new System.Windows.Forms.Label();
            this.shapeTextBox = new System.Windows.Forms.TextBox();
            this.penGroupBox.SuspendLayout();
            this.penStyleGroupBox.SuspendLayout();
            this.brushGroupBox.SuspendLayout();
            this.brushStyleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(63, 44);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(59, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(63, 70);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(59, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(63, 96);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(59, 20);
            this.widthTextBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(63, 122);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(59, 20);
            this.heightTextBox.TabIndex = 3;
            // 
            // penColorPanel
            // 
            this.penColorPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.penColorPanel.Location = new System.Drawing.Point(142, 114);
            this.penColorPanel.Name = "penColorPanel";
            this.penColorPanel.Size = new System.Drawing.Size(24, 20);
            this.penColorPanel.TabIndex = 4;
            // 
            // penColorTextBox
            // 
            this.penColorTextBox.Enabled = false;
            this.penColorTextBox.Location = new System.Drawing.Point(13, 114);
            this.penColorTextBox.Name = "penColorTextBox";
            this.penColorTextBox.Size = new System.Drawing.Size(110, 20);
            this.penColorTextBox.TabIndex = 5;
            // 
            // penGroupBox
            // 
            this.penGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penGroupBox.Controls.Add(this.penStyleGroupBox);
            this.penGroupBox.Controls.Add(this.penColorLabel);
            this.penGroupBox.Controls.Add(this.penColorTextBox);
            this.penGroupBox.Controls.Add(this.penColorPanel);
            this.penGroupBox.Location = new System.Drawing.Point(22, 161);
            this.penGroupBox.Name = "penGroupBox";
            this.penGroupBox.Size = new System.Drawing.Size(317, 151);
            this.penGroupBox.TabIndex = 11;
            this.penGroupBox.TabStop = false;
            this.penGroupBox.Text = "Pen";
            // 
            // penStyleGroupBox
            // 
            this.penStyleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penStyleGroupBox.Controls.Add(this.penStyleComboBox);
            this.penStyleGroupBox.Location = new System.Drawing.Point(9, 19);
            this.penStyleGroupBox.Name = "penStyleGroupBox";
            this.penStyleGroupBox.Size = new System.Drawing.Size(298, 62);
            this.penStyleGroupBox.TabIndex = 18;
            this.penStyleGroupBox.TabStop = false;
            this.penStyleGroupBox.Text = "Style";
            // 
            // penColorLabel
            // 
            this.penColorLabel.AutoSize = true;
            this.penColorLabel.Location = new System.Drawing.Point(10, 91);
            this.penColorLabel.Name = "penColorLabel";
            this.penColorLabel.Size = new System.Drawing.Size(31, 13);
            this.penColorLabel.TabIndex = 12;
            this.penColorLabel.Text = "Color";
            this.penColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // brushGroupBox
            // 
            this.brushGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brushGroupBox.Controls.Add(this.brushStyleGroupBox);
            this.brushGroupBox.Controls.Add(this.label3);
            this.brushGroupBox.Controls.Add(this.brushColorTextBox);
            this.brushGroupBox.Controls.Add(this.brushColorPanel);
            this.brushGroupBox.Location = new System.Drawing.Point(22, 333);
            this.brushGroupBox.Name = "brushGroupBox";
            this.brushGroupBox.Size = new System.Drawing.Size(317, 154);
            this.brushGroupBox.TabIndex = 13;
            this.brushGroupBox.TabStop = false;
            this.brushGroupBox.Text = "Brush";
            // 
            // brushStyleGroupBox
            // 
            this.brushStyleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brushStyleGroupBox.Controls.Add(this.brushStyleComboBox);
            this.brushStyleGroupBox.Location = new System.Drawing.Point(13, 19);
            this.brushStyleGroupBox.Name = "brushStyleGroupBox";
            this.brushStyleGroupBox.Size = new System.Drawing.Size(298, 62);
            this.brushStyleGroupBox.TabIndex = 19;
            this.brushStyleGroupBox.TabStop = false;
            this.brushStyleGroupBox.Text = "Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // brushColorTextBox
            // 
            this.brushColorTextBox.Enabled = false;
            this.brushColorTextBox.Location = new System.Drawing.Point(13, 112);
            this.brushColorTextBox.Name = "brushColorTextBox";
            this.brushColorTextBox.Size = new System.Drawing.Size(110, 20);
            this.brushColorTextBox.TabIndex = 5;
            // 
            // brushColorPanel
            // 
            this.brushColorPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brushColorPanel.Location = new System.Drawing.Point(142, 112);
            this.brushColorPanel.Name = "brushColorPanel";
            this.brushColorPanel.Size = new System.Drawing.Size(24, 20);
            this.brushColorPanel.TabIndex = 4;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(383, 25);
            this.bindingNavigator.TabIndex = 14;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(28, 44);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(28, 70);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 15;
            this.yLabel.Text = "Y";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(19, 96);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 16;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(19, 122);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 17;
            this.heightLabel.Text = "Height";
            // 
            // penStyleComboBox
            // 
            this.penStyleComboBox.FormattingEnabled = true;
            this.penStyleComboBox.Location = new System.Drawing.Point(95, 19);
            this.penStyleComboBox.Name = "penStyleComboBox";
            this.penStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.penStyleComboBox.TabIndex = 18;
            // 
            // brushStyleComboBox
            // 
            this.brushStyleComboBox.FormattingEnabled = true;
            this.brushStyleComboBox.Location = new System.Drawing.Point(91, 22);
            this.brushStyleComboBox.Name = "brushStyleComboBox";
            this.brushStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.brushStyleComboBox.TabIndex = 19;
            // 
            // shapeBindingSource
            // 
            this.shapeBindingSource.DataSource = typeof(Group_8_Homework_7.Shape);
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(197, 51);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(38, 13);
            this.shapeLabel.TabIndex = 18;
            this.shapeLabel.Text = "Shape";
            // 
            // shapeTextBox
            // 
            this.shapeTextBox.Enabled = false;
            this.shapeTextBox.Location = new System.Drawing.Point(200, 70);
            this.shapeTextBox.Name = "shapeTextBox";
            this.shapeTextBox.Size = new System.Drawing.Size(74, 20);
            this.shapeTextBox.TabIndex = 19;
            // 
            // ShapeOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 531);
            this.Controls.Add(this.shapeTextBox);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.brushGroupBox);
            this.Controls.Add(this.penGroupBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Name = "ShapeOptionsDialog";
            this.Text = "Shape Options";
            this.penGroupBox.ResumeLayout(false);
            this.penGroupBox.PerformLayout();
            this.penStyleGroupBox.ResumeLayout(false);
            this.brushGroupBox.ResumeLayout(false);
            this.brushGroupBox.PerformLayout();
            this.brushStyleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource shapeBindingSource;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Panel penColorPanel;
        private System.Windows.Forms.TextBox penColorTextBox;
        private System.Windows.Forms.GroupBox penGroupBox;
        private System.Windows.Forms.Label penColorLabel;
        private System.Windows.Forms.GroupBox brushGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brushColorTextBox;
        private System.Windows.Forms.Panel brushColorPanel;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.GroupBox penStyleGroupBox;
        private System.Windows.Forms.GroupBox brushStyleGroupBox;
        private System.Windows.Forms.ComboBox penStyleComboBox;
        private System.Windows.Forms.ComboBox brushStyleComboBox;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.TextBox shapeTextBox;
    }
}