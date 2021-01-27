using AttributesLib;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace ExtensibleGUI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        public void LoadExtensions()
        {
            string[] extensionsPathes = Directory.GetFiles(Directory.GetCurrentDirectory() + "//extensions");
            foreach (string path in extensionsPathes)
            {
                ExpandApplication(path);
            }
        }

        public void ExpandApplication(string path)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFile(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (assembly != null)
            {
                FindForm(assembly);
            }
        }

        public void FindForm(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.BaseType == typeof(Form))
                {
                    SetFormInContainerAccordingAttributes(type);
                }
            }
        }

        public void SetFormInContainerAccordingAttributes(Type type)
        {
            var attributes = type.GetCustomAttributes();
            foreach (Attribute attribute in attributes)
            {
                if (attribute is GroupBoxContainerAttribute groupBoxContainerAttribute)
                {
                    if (groupBoxContainerAttribute.ContainerIsGroupBox)
                        InsertFormIntoGroupBox((Form)Activator.CreateInstance(type));
                }
                else if (attribute is TabControlContainerAttribute tabControlContainerAttribute)
                {
                    if(tabControlContainerAttribute.TabControlIsContainer)
                        InsertFormIntoTabControl((Form)Activator.CreateInstance(type));
                }
                else if (attribute is PanelContainerAttribute panelContainerAttribute)
                {
                    if (panelContainerAttribute.PanelIsContainer)
                        InsertFormIntoPanel((Form)Activator.CreateInstance(type));
                }
            }
        }

        public void InsertFormIntoTabControl(Form form)
        {
            TabPage tabPage = new TabPage();

            Control[] controls = GetControlsFromForm(form);

            tabPage.Controls.AddRange(controls);
            tabPage.Text = form.Text;
            TabControl.TabPages.Add(tabPage);
        }

        public void InsertFormIntoGroupBox(Form form)
        {
            Control[] controls = GetControlsFromForm(form);

            int bottomBorder = GetBottomBorder(GroupBox.Controls);
            UpdateControlLocation(controls, bottomBorder);

            GroupBox.Controls.AddRange(controls);
        }

        public void InsertFormIntoPanel(Form form)
        {
            Control[] controls = GetControlsFromForm(form);

            int bottomBorder = GetBottomBorder(Panel.Controls);
            UpdateControlLocation(controls, bottomBorder);

            Panel.Controls.AddRange(controls);
        }

        public Control[] GetControlsFromForm(Form form)
        {
            var controls = new Control[form.Controls.Count];
            form.Controls.CopyTo(controls, 0);

            return controls;
        }

        public int GetBottomBorder(Control.ControlCollection controls)
        {
            int result = 0;
            foreach (Control control in controls)
            {
                if (control.Bottom > result)
                {
                    result = control.Bottom;
                }
            }
            return result;
        }

        public void UpdateControlLocation(Control[] controls , int bottomBorder)
        {
            foreach (Control control in controls)
            {
                control.Top += bottomBorder;
            }
        }

        private void FMain_Shown(object sender, EventArgs e) => LoadExtensions();
    }
}
