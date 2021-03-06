using System;
using System.Windows.Forms;

namespace Redmine.Client
{
    public enum DialogType
    {
        New,
        Edit,
    };

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                AppDomain.CurrentDomain.UnhandledException += new
                    UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            }
            catch (Exception)
            { }
            try
            {
                Application.Run(RedmineClientForm.Instance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handler for the weird exceptions we are not handling in our code and especially for the CLR20r3 stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            Console.WriteLine("Observed unhandled exception: {0}", ex.ToString());
        }

    }
}
