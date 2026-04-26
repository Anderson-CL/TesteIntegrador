using CaixaIntegrador.Data;

namespace CaixaIntegrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaInicial());
        }
    }
}
