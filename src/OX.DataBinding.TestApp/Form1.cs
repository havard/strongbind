using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OX.Strongbind.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IBusinessObject o = new BusinessObject();
            IBusinessObject b = Bindable.Source(o);
            Form c = Bindable.Target(this);
            Binder.Bind(b.Name).To(c.Text);
        }
    }
}