using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransientHeat
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Itago muna ang current form (AboutForm o anumang ibang form na bukas)
            this.Hide();

            // Bumalik sa MainMenu
            MainMenu mainMenu = new MainMenu();
            mainMenu.FormClosed += (s, args) => this.Close(); // I-close ang kasalukuyang form kapag na-close na ang MainMenu
            mainMenu.Show();
        }

    }
}
