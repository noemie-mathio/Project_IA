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
            questionlabel.Visible = false;
            questiontextBox.Visible = false;
            reponse1label.Visible = false;
            reponse1textBox.Visible = false;
            reponse2label.Visible = false;
            reponse2textBox.Visible = false;
            reponse3label.Visible = false;
            reponse3textBox.Visible = false;
            reponse4label.Visible = false;
            reponse4textBox.Visible = false;
            bonnereponselabel.Visible = false;
            bonnereponsetextBox.Visible = false;
            explicationBonneReponselabel.Visible = false;
            explicationBonneReponsetextBox.Visible = false;
            envoyerbutton.Visible = false;

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

                questionlabel.Visible = true;
                questiontextBox.Visible = true ;
                reponse1label.Visible = true;
                reponse1textBox.Visible = true;
                reponse2label.Visible = true;
                reponse2textBox.Visible = true;
                reponse3label.Visible = true;
                reponse3textBox.Visible = true;
                reponse4label.Visible = true;
                reponse4textBox.Visible = true;
                bonnereponselabel.Visible = true;
                bonnereponsetextBox.Visible = true;
                explicationBonneReponselabel.Visible = true;
                explicationBonneReponsetextBox.Visible = true;
                envoyerbutton.Visible = true;
            }

            else
            {
                msgErreurLabel.Visible = true;
                titreLabel.Visible = true; 
            }
        }

        private void mdpTextBox_TextChanged(object sender, EventArgs e)
        {
            mdpTextBox.Text = "";

            mdpTextBox.PasswordChar='*';
        }
    }
}
