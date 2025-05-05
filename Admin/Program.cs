using Microsoft.EntityFrameworkCore;
using SharedDB;

namespace OOP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var dbConnection = new DatabaseConnection<ApplicationDbContext>("CHRIS", "OOPEnrollmentSystem");
            dbConnection.ContextInitialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new AdminDashboard(dbConnection.Context));
        }
    }
}