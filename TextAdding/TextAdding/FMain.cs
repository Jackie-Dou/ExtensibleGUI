using AttributesLib;
using System;
using System.Windows.Forms;

namespace TextAdding
{
    [PanelContainer(true)]
    [GroupBoxContainer(true)]
    [TabControlContainer(true)]
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void ButAddLine_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                ListBox.Items.Add(TextBox.Text);
                TextBox.Text = "";
            }
        }
    }
}
