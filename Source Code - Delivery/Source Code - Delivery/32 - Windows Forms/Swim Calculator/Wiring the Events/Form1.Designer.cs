namespace Creating_the_Project {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.convertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.lapsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poolLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calsPerHour = new System.Windows.Forms.NumericUpDown();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.poolLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calsPerHour)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(215, 37);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 122);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = ">";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes:";
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(67, 37);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(120, 20);
            this.minutesTextBox.TabIndex = 0;
            this.minutesTextBox.Text = "0";
            this.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minutesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyPress);
            // 
            // lapsTextBox
            // 
            this.lapsTextBox.Location = new System.Drawing.Point(67, 71);
            this.lapsTextBox.Name = "lapsTextBox";
            this.lapsTextBox.Size = new System.Drawing.Size(120, 20);
            this.lapsTextBox.TabIndex = 1;
            this.lapsTextBox.Text = "0";
            this.lapsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lapsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laps:";
            // 
            // poolLength
            // 
            this.poolLength.Location = new System.Drawing.Point(67, 105);
            this.poolLength.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.poolLength.Name = "poolLength";
            this.poolLength.Size = new System.Drawing.Size(120, 20);
            this.poolLength.TabIndex = 5;
            this.poolLength.TabStop = false;
            this.poolLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.poolLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length (m):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cals/hr:";
            // 
            // calsPerHour
            // 
            this.calsPerHour.Location = new System.Drawing.Point(67, 139);
            this.calsPerHour.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.calsPerHour.Name = "calsPerHour";
            this.calsPerHour.Size = new System.Drawing.Size(120, 20);
            this.calsPerHour.TabIndex = 7;
            this.calsPerHour.TabStop = false;
            this.calsPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calsPerHour.Value = new decimal(new int[] {
            1070,
            0,
            0,
            0});
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(318, 38);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(175, 121);
            this.resultsTextBox.TabIndex = 6;
            this.resultsTextBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 218);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calsPerHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poolLength);
            this.Controls.Add(this.lapsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Swim Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.poolLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calsPerHour)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox lapsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown poolLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown calsPerHour;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

