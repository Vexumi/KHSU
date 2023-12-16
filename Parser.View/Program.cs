using Microsoft.EntityFrameworkCore;

namespace Parser.View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MramorExperiments;Trusted_Connection=True;";
            var context = new ApplicationContext(connectionString);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(context));
        }
    }
}