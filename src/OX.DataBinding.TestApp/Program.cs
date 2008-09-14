using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OX.DataBinding.TestApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            f.Bind();
            Application.Run(f);
        }
    }
}