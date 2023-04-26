using SupermarketHorta_mvp._Repositories;
using SupermarketHorta_mvp.Models;
using SupermarketHorta_mvp.Presenters;
using SupermarketHorta_mvp.Properties;
using SupermarketHorta_mvp.Views;

namespace SupermarketHorta_mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            Application.Run(new PayModeView());
            new PayModePresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}