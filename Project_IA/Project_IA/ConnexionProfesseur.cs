using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IA
{
    public partial class ConnexionProfesseur : Form
    {
        public ConnexionProfesseur()
        {
            InitializeComponent();
            msgErreurLabel.Visible = false;

        }

        private void validerIdentifiantButton_Click(object sender, EventArgs e)
        {
            if (pseudoTextBox.Text == "professeur" && mdpTextBox.Text == "secret")
            {

                Accueil accueil1 = new Accueil(true);
                accueil1.Show();
                this.Hide();
            }
            else
            {
                msgErreurLabel.Visible = true;
            }
        }
        private void mdpTextBox_TextChanged(object sender, EventArgs e)
        {
            mdpTextBox.PasswordChar = '*';
        }

        private void Retourbutton_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Hide();
        }

        
    }
}
