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
    public partial class Quizz : Form
    {
        public List<QuestionsCours> questionsCours;
        public Random random = new Random();
        public List<QuestionsCours> quizzzzz { get; set; }
        int num_ref=0;
        public QuestionsCours questionPosée;

        public Quizz()
        {
            InitializeComponent();
            deserializeFromXmlFile("test_question.xml");
            quizzzzz = new List<QuestionsCours>();
            newQuiz();
            newQuestion();
            
        }
        public List<QuestionsCours> deserializeFromXmlFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionsCours>));

            StreamReader reader = new StreamReader(filePath);
            questionsCours = (List<QuestionsCours>)serializer.Deserialize(reader);
            reader.Close();
            return questionsCours;
        }
        public void newQuiz()
        {
            int count = questionsCours.Count;
            int questionCount = 0;
            int[] librairie = new int[20];

            while (questionCount < 20)
            {
                int numRandom = 0;
                bool controle = false;
                while (controle == false)
                {
                    int compteur_question = 0;
                    int randomNumber = random.Next(1, questionsCours.Count);
                    for (int i = 0; i < 20; i++)
                    {
                        if (librairie[i] == randomNumber)
                        {
                            compteur_question++;
                        }
                    }
                    if (compteur_question == 0)
                    {
                        controle = true;
                        numRandom = randomNumber;
                        librairie[questionCount] = randomNumber;

                    }
                }
                QuestionsCours nouvelleQuestion = questionsCours[numRandom];
                quizzzzz.Add(nouvelleQuestion);
                questionCount++;

            }
        }
        private void newQuestion()
        {
            int compteur = 0;
            foreach (QuestionsCours quest in quizzzzz)
            {       if (compteur == num_ref)
                    {
                    questionPosée = quest;
                    num_ref++;
                    break;
                     }
                compteur++;
                labelQuestion.Text = questionPosée.question;
                option1Button.Text = questionPosée.reponse1;
                option2Button.Text = questionPosée.reponse2;
                option3Button.Text = questionPosée.reponse3;
                option4Button.Text = questionPosée.reponse4;
            }



        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }

        private void option1Button_Click(object sender, EventArgs e)
        {

        }

        private void option2Button_Click(object sender, EventArgs e)
        {

        }
    }
}
