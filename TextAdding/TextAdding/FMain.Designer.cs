namespace TextAdding
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ButAddLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(12, 23);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(225, 84);
            this.ListBox.TabIndex = 0;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(252, 23);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(225, 27);
            this.TextBox.TabIndex = 1;
            // 
            // ButAddLine
            // 
            this.ButAddLine.Location = new System.Drawing.Point(252, 77);
            this.ButAddLine.Name = "ButAddLine";
            this.ButAddLine.Size = new System.Drawing.Size(225, 30);
            this.ButAddLine.TabIndex = 2;
            this.ButAddLine.Text = "Add";
            this.ButAddLine.UseVisualStyleBackColor = true;
            this.ButAddLine.Click += new System.EventHandler(this.ButAddLine_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 126);
            this.Controls.Add(this.ButAddLine);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ListBox);
            this.Name = "FMain";
            this.Text = "Text adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ButAddLine;
    }
}

