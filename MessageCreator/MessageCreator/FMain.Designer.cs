namespace MessageCreator
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ButShowText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(61, 25);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(219, 27);
            this.TextBox.TabIndex = 0;
            // 
            // ButShowText
            // 
            this.ButShowText.Location = new System.Drawing.Point(105, 72);
            this.ButShowText.Name = "ButShowText";
            this.ButShowText.Size = new System.Drawing.Size(126, 29);
            this.ButShowText.TabIndex = 1;
            this.ButShowText.Text = "Create";
            this.ButShowText.UseVisualStyleBackColor = true;
            this.ButShowText.Click += new System.EventHandler(this.ButShowText_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 123);
            this.Controls.Add(this.ButShowText);
            this.Controls.Add(this.TextBox);
            this.Name = "FMain";
            this.Text = "MessageCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ButShowText;
    }
}

