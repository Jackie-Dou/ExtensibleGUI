using AttributesLib;
using System;
using System.Windows.Forms;

namespace MessageCreator
{
    [GroupBoxContainer(true)]
    [TabControlContainer(true)]
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void ButShowText_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                MessageBox.Show(TextBox.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show("Oh, sorry, the field was empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TextBox.Text = "";
        }
    }
}
