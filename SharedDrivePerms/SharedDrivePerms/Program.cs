using System;
using System.Threading;
using System.Windows.Forms;

namespace SharedDrivePerms
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
                                  
            AppDomain.CurrentDomain.UnhandledException += AppDomain_UnhandledException;

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.Run(new MainFrom());
        }
        static void Application_ThreadException(Object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Application.ThreadException");
            
        }

        static void AppDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)e.ExceptionObject).Message, "AppDomain.UnhandledException");
        }
    }
    
}
