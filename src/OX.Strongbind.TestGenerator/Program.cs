using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using OX.Strongbind.Tests;

namespace OX.Strongbind.TestGenerator
{
    class Program
    {
        readonly static List<string> IgnoreClassesList = new List<string>(new string[] { "WebBrowser" });
        readonly static List<string> IgnorePropertiesList = new List<string>(new string[] { 
            "BindingNavigator.Text",
            "CheckedListBox.ItemHeight", 
            "CheckedListBox.SelectedIndex", 
            "CheckedListBox.TopIndex",
            "CheckedListBox.Height",
            "ComboBox.ItemHeight", 
            "ComboBox.SelectedIndex", 
            "ComboBox.SelectedText", 
            "ComboBox.SelectionLength", 
            "ComboBox.SelectionStart", 
            "ComboBox.Height",
            "ContextMenuStrip.Opacity", 
            "ContextMenuStrip.TabIndex", 
            "ContextMenuStrip.Left",
            "ContextMenuStrip.Top",
            "ContextMenuStrip.Name", 
            "ContextMenuStrip.Text", 
            "ContextMenuStrip.AccessibleDefaultActionDescription", 
            "ContextMenuStrip.AccessibleDescription",
            "ContextMenuStrip.AccessibleName", 
            "ContextMenuStrip.Height", 
            "ContextMenuStrip.Width",
            "DataGrid.CurrentRowIndex", 
            "DataGridTextBox.Height", 
            "DataGridTextBox.SelectedText", 
            "DataGridView.FirstDisplayedScrollingColumnIndex",
            "DataGridView.FirstDisplayedScrollingRowIndex", 
            "DataGridViewComboBoxEditingControl.ItemHeight",
            "DataGridViewComboBoxEditingControl.SelectedIndex", 
            "DataGridViewComboBoxEditingControl.SelectedText",
            "DataGridViewComboBoxEditingControl.SelectionLength",
            "DataGridViewComboBoxEditingControl.SelectionStart",
            "DataGridViewComboBoxEditingControl.AccessibleDefaultActionDescription",
            "DataGridViewComboBoxEditingControl.AccessibleDescription",
            "DataGridViewComboBoxEditingControl.AccessibleName",
            "DataGridViewComboBoxEditingControl.Height",
            "DataGridViewTextBoxEditingControl.SelectedText",
            "DataGridViewTextBoxEditingControl.Text", 
            "DataGridViewTextBoxEditingControl.SelectionLength",
            "DataGridViewTextBoxEditingControl.SelectionStart",
            "DataGridViewTextBoxEditingControl.AccessibleDefaultActionDescription",
            "DataGridViewTextBoxEditingControl.AccessibleDescription",
            "DataGridViewTextBoxEditingControl.AccessibleName",
            "DataGridViewTextBoxEditingControl.Height",
            "DateTimePicker.Height", 
            "DateTimePicker.Text", 
            "DomainUpDown.Height", 
            "DomainUpDown.SelectedIndex", 
            "Form.Opacity",
            "Form.TabIndex", 
            "Form.Text",
            "Form.AccessibleDefaultActionDescription",
            "Form.AccessibleDescription", 
            "Form.AccessibleName", 
            "Form.Height",
            "Form.Left", 
            "Form.Top", 
            "Form.Name", 
            "Form.Width",
            "HScrollBar.SmallChange", 
            "ListBox.ItemHeight", 
            "ListBox.SelectedIndex", 
            "ListBox.TopIndex",
            "ListBox.Height",
            "MaskedTextBox.MaxLength",
            "MaskedTextBox.SelectedText", 
            "MaskedTextBox.SelectionLength", 
            "MaskedTextBox.SelectionStart", 
            "MaskedTextBox.AccessibleDefaultActionDescription",
            "MaskedTextBox.AccessibleDescription",
            "MaskedTextBox.AccessibleName",
            "MaskedTextBox.Height",
            "MonthCalendar.Height", 
            "MonthCalendar.Width", 
            "NumericUpDown.Height", 
            "NumericUpDown.Text", 
            "PrintPreviewDialog.AccessibleName", 
            "PrintPreviewDialog.AccessibleDescription", 
            "PrintPreviewDialog.AccessibleDefaultActionDescription",
            "PrintPreviewDialog.Text", 
            "PrintPreviewDialog.Opacity", 
            "PrintPreviewDialog.TabIndex",
            "PrintPreviewDialog.Height", 
            "PrintPreviewDialog.Left", 
            "PrintPreviewDialog.Top",
            "PrintPreviewDialog.Name", 
            "PrintPreviewDialog.Width",
            "RichTextBox.Rtf", 
            "RichTextBox.SelectionLength", 
            "RichTextBox.SelectedRtf",
            "RichTextBox.SelectedText", 
            "RichTextBox.SelectionStart",
            "RichTextBox.AccessibleDefaultActionDescription", 
            "RichTextBox.AccessibleDescription",
            "RichTextBox.AccessibleName",
            "SplitContainer.Width", 
            "Splitter.SplitPosition", 
            "TabControl.SelectedIndex", 
            "TextBox.Height", 
            "TextBox.SelectedText", 
            "ToolBar.Height", 
            "ToolStripDropDown.Opacity",
            "ToolStripDropDown.TabIndex", 
            "ToolStripDropDown.AccessibleDefaultActionDescription",
            "ToolStripDropDown.AccessibleDescription", 
            "ToolStripDropDown.AccessibleName",
            "ToolStripDropDown.Height", 
            "ToolStripDropDown.Left", 
            "ToolStripDropDown.Top", 
            "ToolStripDropDown.Name", 
            "ToolStripDropDown.Text", 
            "ToolStripDropDown.Width",
            "ToolStripDropDownMenu.Opacity", 
            "ToolStripDropDownMenu.TabIndex", 
            "ToolStripDropDownMenu.AccessibleDefaultActionDescription",
            "ToolStripDropDownMenu.AccessibleDescription", 
            "ToolStripDropDownMenu.AccessibleName",
            "ToolStripDropDownMenu.Height",
            "ToolStripDropDownMenu.Left", 
            "ToolStripDropDownMenu.Top", 
            "ToolStripDropDownMenu.Name", 
            "ToolStripDropDownMenu.Text", 
            "ToolStripDropDownMenu.Width",
            "TrackBar.Height", 
            "TreeView.ImageIndex", 
            "TreeView.SelectedImageIndex", 
            "TreeView.SelectedImageKey", 
            "VScrollBar.SmallChange"
        });
        static void Main(string[] args)
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase.Substring(8));
            
            string outputFile = args.Length == 1 ? args[0] : "GeneratedBindingTests.cs";

            Dictionary<Type, string> props = new Dictionary<Type,string>();
            foreach (PropertyInfo property in typeof(IBusinessObject).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                props.Add(property.PropertyType, property.Name);
            }

            string testFixtureTemplate = File.ReadAllText("testclass.cst");
            
            StringBuilder tests = new StringBuilder();
            
            foreach (Type type in Assembly.GetAssembly(typeof(Form)).GetExportedTypes())
            {
                if (IsTestableType(type))
                    tests.Append(CreateTestForType(type, props));
            }

            string generatedCode = testFixtureTemplate.Replace("%TESTS%", tests.ToString());

            WriteFile(outputFile, generatedCode);
        }

        private static bool IsTestableType(Type type)
        {
            return typeof(IBindableComponent).IsAssignableFrom(type)
                && type.IsClass && type.IsPublic && !type.IsGenericType && !type.IsAbstract
                && type.GetConstructor(Type.EmptyTypes) != null
                && !IgnoreClassesList.Contains(type.Name);
        }

        private static void WriteFile(string outputFile, string generatedCode)
        {
            if (File.Exists(outputFile))
                File.Delete(outputFile);

            using (FileStream f = File.OpenWrite(outputFile))
            {
                using (StreamWriter sw = new StreamWriter(f))
                {
                    sw.Write(generatedCode);
                }
            }
        }

        private static string CreateTestForType(Type type, Dictionary<Type, string> testableProperties)
        {
            string testTemplate = File.ReadAllText("test.cst");            

            StringBuilder properties = new StringBuilder();

            string propertyTemplate = File.ReadAllText("binding.cst");
            
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (!IsTestableProperty(property, type, testableProperties))
                    continue;

                string sourceProperty = testableProperties[property.PropertyType];

                properties.Append(propertyTemplate.Replace("%SOURCEPROPERTY%", sourceProperty)
                    .Replace("%TARGETPROPERTY%", property.Name));
            }

            return testTemplate.Replace("%CONTROL%", type.Name)
                .Replace("%BINDINGS%", properties.ToString());
        }

        private static bool IsTestableProperty(PropertyInfo property, Type type, Dictionary<Type, string> testableProperties)
        {
            return property.CanWrite && testableProperties.ContainsKey(property.PropertyType)
                && !IgnorePropertiesList.Contains(type.Name + "." + property.Name);
        }
    }
}
