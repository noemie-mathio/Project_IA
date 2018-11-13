using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Project_IA
{
    public partial class NouvelleQuestionQuiz : Form
    {
        public List<QuestionsCours> listeQuestionsCours;

        public NouvelleQuestionQuiz()
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
            mdpTextBox.PasswordChar='*';
        }

        private void envoyerbutton_Click(object sender, EventArgs e)
        {
            if (questiontextBox.Text != null && reponse1textBox.Text != null && reponse2textBox.Text != null && reponse3textBox.Text != null && reponse4textBox.Text != null && bonnereponsetextBox.Text != null && explicationBonneReponsetextBox.Text != null)
            {
                DeserializeFromXml("test_question.xml");
                Serialisation(listeQuestionsCours, questiontextBox.Text, reponse1textBox.Text, reponse2textBox.Text, reponse3textBox.Text, reponse4textBox.Text, int.Parse(bonnereponsetextBox.Text), explicationBonneReponsetextBox.Text);
                MessageBox.Show("Votre question a bien été ajoutée");
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
        }
        public static void Serialisation(List<QuestionsCours> questions, string question, string reponse1, string reponse2, string reponse3, string reponse4, int bonnereponse, string explicationBonnereponse)
        {

            QuestionsCours question_1 = new QuestionsCours(question, reponse1, reponse2, reponse3, reponse4,bonnereponse, explicationBonnereponse);

            questions.Add(question_1);
      
            XmlSerializer xs = new XmlSerializer(typeof(List<QuestionsCours>));
            using (StreamWriter wr = new StreamWriter("test_question.xml"))
            {
                xs.Serialize(wr, questions);
            }
        }
        public  List<QuestionsCours> DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionsCours>));

            StreamReader reader = new StreamReader(filePath);
            listeQuestionsCours = (List<QuestionsCours>)serializer.Deserialize(reader);
            reader.Close();
            return listeQuestionsCours;
        }

       
    }
}
