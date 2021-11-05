using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht
{
    static class Program
    {
        static bool IsRunning = true;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RenderForm form = new();
            form.FormClosing += Form_FormClosing;
            form.Show();

            while (IsRunning)
            {
                form.Invalidate();
                Application.DoEvents();
            }

            form.Close();
            form.Dispose();
        }

        private static void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsRunning = false;
        }
    }

}

