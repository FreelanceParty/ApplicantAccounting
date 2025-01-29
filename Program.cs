using ApplicantAccounting.Forms;
using ApplicantAccounting.Models.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ApplicantAccounting;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        ReloadDatabase();
        Application.Run(new MainForm());
    }

    static void ReloadDatabase()
    {
        string databasePath = "applicant_accounting.db";
        if (File.Exists(databasePath))
        {
            File.Delete(databasePath);
        }
        else
        {
            File.Create(databasePath);
        }

        using var context = new AppDbContext();
        var seeder = new RecordSeeder(context);
        seeder.Seed(10);
    }
}