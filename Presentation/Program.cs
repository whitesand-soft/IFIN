using System;
using System.Windows.Forms;
using Presentation.App;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IFIN.Bootstrap();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mv = new MainView();
            mv.Presenter = new MainPresenter(mv);
            Application.Run(mv);
        }
    }
}
