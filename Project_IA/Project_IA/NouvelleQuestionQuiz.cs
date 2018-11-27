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
            erreurlabel.Visible = false;

        }
        
        private void envoyerbutton_Click(object sender, EventArgs e)
        {
            if (questiontextBox.Text != "" && reponse1textBox.Text != "" && reponse2textBox.Text != "" && reponse3textBox.Text != "" && reponse4textBox.Text != "" && bonnereponsetextBox.Text != "" && explicationBonneReponsetextBox.Text != "")
            {
                DeserializeFromXml("test_question.xml");
                Serialisation(listeQuestionsCours, questiontextBox.Text, reponse1textBox.Text, reponse2textBox.Text, reponse3textBox.Text, reponse4textBox.Text, int.Parse(bonnereponsetextBox.Text), explicationBonneReponsetextBox.Text);
                MessageBox.Show("Votre question a bien été ajoutée");
                Accueil accueil = new Accueil(true);
                accueil.Show();
                this.Hide();
            }
            else
            {
                erreurlabel.Visible = true;
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
