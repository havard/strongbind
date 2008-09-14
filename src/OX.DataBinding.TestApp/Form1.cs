using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OX.DataBinding.TestApp
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

        public void Bind()
        {
            //IBusinessObject o = new BusinessObject();
            //IBusinessObject b = Bindable.Source(o);
            //Form c = Bindable.Target(this);
            //Binder.Bind(b.Name).To(c.Text);
        }
        
    }
}