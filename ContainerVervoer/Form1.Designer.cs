namespace ContainerVervoer
{
    partial class Form1
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
            this.lbPlace1 = new System.Windows.Forms.ListBox();
            this.lbPlace4 = new System.Windows.Forms.ListBox();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPlace2 = new System.Windows.Forms.ListBox();
            this.lbPlace5 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPlace3 = new System.Windows.Forms.ListBox();
            this.lbPlace6 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ndShipWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ndContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.cbValuable = new System.Windows.Forms.CheckBox();
            this.cbCooled = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndShipWeight)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndContainerWeight)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlace1
            // 
            this.lbPlace1.FormattingEnabled = true;
            this.lbPlace1.Location = new System.Drawing.Point(6, 19);
            this.lbPlace1.Name = "lbPlace1";
            this.lbPlace1.Size = new System.Drawing.Size(187, 69);
            this.lbPlace1.TabIndex = 0;
            // 
            // lbPlace4
            // 
            this.lbPlace4.FormattingEnabled = true;
            this.lbPlace4.Location = new System.Drawing.Point(6, 94);
            this.lbPlace4.Name = "lbPlace4";
            this.lbPlace4.Size = new System.Drawing.Size(187, 69);
            this.lbPlace4.TabIndex = 3;
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.Location = new System.Drawing.Point(6, 19);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(187, 199);
            this.lbContainers.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPlace2);
            this.groupBox1.Controls.Add(this.lbPlace1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front ship";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPlace4);
            this.groupBox2.Controls.Add(this.lbPlace3);
            this.groupBox2.Location = new System.Drawing.Point(211, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Middle ship";
            // 
            // lbPlace2
            // 
            this.lbPlace2.FormattingEnabled = true;
            this.lbPlace2.Location = new System.Drawing.Point(6, 94);
            this.lbPlace2.Name = "lbPlace2";
            this.lbPlace2.Size = new System.Drawing.Size(187, 69);
            this.lbPlace2.TabIndex = 0;
            // 
            // lbPlace5
            // 
            this.lbPlace5.FormattingEnabled = true;
            this.lbPlace5.Location = new System.Drawing.Point(6, 19);
            this.lbPlace5.Name = "lbPlace5";
            this.lbPlace5.Size = new System.Drawing.Size(187, 69);
            this.lbPlace5.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPlace6);
            this.groupBox3.Controls.Add(this.lbPlace5);
            this.groupBox3.Location = new System.Drawing.Point(416, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 179);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Back ship";
            // 
            // lbPlace3
            // 
            this.lbPlace3.FormattingEnabled = true;
            this.lbPlace3.Location = new System.Drawing.Point(6, 19);
            this.lbPlace3.Name = "lbPlace3";
            this.lbPlace3.Size = new System.Drawing.Size(187, 69);
            this.lbPlace3.TabIndex = 0;
            // 
            // lbPlace6
            // 
            this.lbPlace6.FormattingEnabled = true;
            this.lbPlace6.Location = new System.Drawing.Point(6, 94);
            this.lbPlace6.Name = "lbPlace6";
            this.lbPlace6.Size = new System.Drawing.Size(187, 69);
            this.lbPlace6.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 203);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ship";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox5.Controls.Add(this.btnSet);
            this.groupBox5.Controls.Add(this.ndShipWeight);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 89);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ship configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight in kg:";
            // 
            // ndShipWeight
            // 
            this.ndShipWeight.Location = new System.Drawing.Point(7, 33);
            this.ndShipWeight.Maximum = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.ndShipWeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ndShipWeight.Name = "ndShipWeight";
            this.ndShipWeight.Size = new System.Drawing.Size(192, 20);
            this.ndShipWeight.TabIndex = 1;
            this.ndShipWeight.Value = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox6.Controls.Add(this.btnAdd);
            this.groupBox6.Controls.Add(this.cbCooled);
            this.groupBox6.Controls.Add(this.cbValuable);
            this.groupBox6.Controls.Add(this.ndContainerWeight);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(12, 122);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 134);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add container";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight in kg:";
            // 
            // ndContainerWeight
            // 
            this.ndContainerWeight.Location = new System.Drawing.Point(6, 32);
            this.ndContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.ndContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.ndContainerWeight.Name = "ndContainerWeight";
            this.ndContainerWeight.Size = new System.Drawing.Size(193, 20);
            this.ndContainerWeight.TabIndex = 2;
            this.ndContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // cbValuable
            // 
            this.cbValuable.AutoSize = true;
            this.cbValuable.Location = new System.Drawing.Point(6, 58);
            this.cbValuable.Name = "cbValuable";
            this.cbValuable.Size = new System.Drawing.Size(67, 17);
            this.cbValuable.TabIndex = 3;
            this.cbValuable.Text = "Valuable";
            this.cbValuable.UseVisualStyleBackColor = true;
            // 
            // cbCooled
            // 
            this.cbCooled.AutoSize = true;
            this.cbCooled.Location = new System.Drawing.Point(6, 81);
            this.cbCooled.Name = "cbCooled";
            this.cbCooled.Size = new System.Drawing.Size(59, 17);
            this.cbCooled.TabIndex = 4;
            this.cbCooled.Text = "Cooled";
            this.cbCooled.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.lbContainers);
            this.groupBox7.Location = new System.Drawing.Point(223, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(199, 229);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unsorted containers";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox8.Location = new System.Drawing.Point(428, 27);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(206, 229);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(6, 59);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(193, 23);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 471);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Container transport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndShipWeight)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndContainerWeight)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlace1;
        private System.Windows.Forms.ListBox lbPlace4;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbPlace2;
        private System.Windows.Forms.ListBox lbPlace5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPlace3;
        private System.Windows.Forms.ListBox lbPlace6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown ndShipWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbCooled;
        private System.Windows.Forms.CheckBox cbValuable;
        private System.Windows.Forms.NumericUpDown ndContainerWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

