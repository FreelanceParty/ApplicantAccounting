using ApplicantAccounting.Forms;

namespace ApplicantAccounting;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}