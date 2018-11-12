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
    public partial class NouvelleQuestion : Form
    {
        public NouvelleQuestion()
        {
            InitializeComponent();
            msgErreurLabel.Visible = false;
            titreLabel.Visible = false;

        }

        private void validerIdentifiantButton_Click(object sender, EventArgs e)
        {
            if (pseudoTextBox.Text == "professeur" && mdpTextBox.Text == "secret")
            {
                mdpTextBox.Visible = false;
                mdpLabel.Visible = false;
                pseudoLabel.Visible = false;
                pseudoTextBox.Visible = false;
                validerIdentifiantButton.Visible = false;
                msgErreurLabel.Visible = false;
            }

            else
            {
                msgErreurLabel.Visible = true;
                titreLabel.Visible = true; 
            }
        }

       
    }
}
