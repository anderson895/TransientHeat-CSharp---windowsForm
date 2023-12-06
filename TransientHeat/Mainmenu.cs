namespace TransientHeat
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Itago muna ang current form
            this.Hide();

            // Open the AboutForm
            AboutForm aboutForm = new AboutForm();
            aboutForm.FormClosed += (s, args) => this.Close(); // I-close ang MainMenu kapag na-close na ang AboutForm
            aboutForm.Show();
        }


        private void btnSolver_Click(object sender, EventArgs e)
        {
            // Itago muna ang current form
            this.Hide();

            // Open the AboutForm
            MainForm solverForm = new MainForm();
            solverForm.FormClosed += (s, args) => this.Close(); // I-close ang MainMenu kapag na-close na ang AboutForm
            solverForm.Show();

        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            // Itago muna ang current form
            this.Hide();

            // Open the AboutForm
            developerForm developerForm = new developerForm();
            developerForm.FormClosed += (s, args) => this.Close(); // I-close ang MainMenu kapag na-close na ang AboutForm
            developerForm.Show();

        }
    }
}