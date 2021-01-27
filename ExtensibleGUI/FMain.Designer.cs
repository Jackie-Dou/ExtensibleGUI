namespace ExtensibleGUI
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.GroupBox.Location = new System.Drawing.Point(27, 25);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(491, 693);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "GroupBox";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Linen;
            this.Panel.Location = new System.Drawing.Point(540, 39);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(510, 679);
            this.Panel.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(1077, 39);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(497, 679);
            this.TabControl.TabIndex = 2;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1586, 730);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.GroupBox);
            this.Name = "FMain";
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.FMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TabControl TabControl;
    }
}

