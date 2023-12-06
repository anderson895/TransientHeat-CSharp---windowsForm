using TransientHeat;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        MainMenu mainMenu = new MainMenu();
        Application.Run(mainMenu);
    }
}
