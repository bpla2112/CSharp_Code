using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoundationControlLibrary;

namespace Group8_Homework_3A
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

            if (!Properties.Settings.Default.SkipScreen)
            {
                LoginDialog login = new LoginDialog();
                if( login.ShowDialog() == DialogResult.OK)
                    Application.Run(new NeoMainForm());
            }
            else
                Application.Run(new NeoMainForm());
        }
    }
}
