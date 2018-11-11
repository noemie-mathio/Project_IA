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
        bool answered;
        int bonnereponse;
        int score;
        int compteur = 0;

        

        public Quizz()
        {
            InitializeComponent();
            //deserializeFromXmlFile("test_question.xml");
            //quizzzzz = new List<QuestionsCours>();
            //newQuiz();
            quizzzzz = new List<QuestionsCours>();
            QuestionsCours question_2 = new QuestionsCours("Quel est la différence entre un servo-contrôleur et un micro-contrôleur?", "Purement sémantique", "Le servo-contrôleur n’est pas programmable", "Le servo-contrôleur ne fonctionne pas en autonomie", "Le micro-contrôleur ne possede pas de mémoire interne", 3, "Blabla");

            quizzzzz.Add(question_2);
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

                    int randomNumber = random.Next(1, count+1);
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
                QuestionsCours nouvelleQuestion = questionsCours[numRandom-1];
                quizzzzz.Add(nouvelleQuestion);
                questionCount++;

            }
        }
        private void newQuestion()
        {
            QuestionsCours questionPosee = quizzzzz.ElementAt(compteur);

            labelQuestion.Text = questionPosee.question;
            option1Button.Text = questionPosee.reponse1;
            option2Button.Text = questionPosee.reponse2;
            option3Button.Text = questionPosee.reponse3;
            option4Button.Text = questionPosee.reponse4;
            bonnereponse = questionPosee.bonnereponse;
        }
        private bool answerCheck(int answerNumber)
        {
            
            if(answerNumber==this.bonnereponse)
            {
                 score++;
               
                return true;       
            }
            else
            {
                return false;
            }
        }


        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            answered=answerCheck(1);
            if(answered==true)
            {
                option1Button.BackColor =Color.Green;
            }
            else if (answerCheck(2) == true)
            {
                option1Button.BackColor = Color.Red;
                option2Button.BackColor = Color.Green;
            }
            else if (answerCheck(3) == true)
            {
                option1Button.BackColor = Color.Red;
                option3Button.BackColor = Color.Green;
            }
            else
            {
                option1Button.BackColor = Color.Red;
                option4Button.BackColor = Color.Green;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            answered = answerCheck(2);
            if (answered == true)
            {
                option2Button.BackColor = Color.Green;
            }
            else if (answerCheck(1)==true)
            {
                option2Button.BackColor = Color.Red;
                option1Button.BackColor = Color.Green;
            }
            else if (answerCheck(3) == true)
            {
                option2Button.BackColor = Color.Red;
                option3Button.BackColor = Color.Green;
            }
            else
            {
                option2Button.BackColor = Color.Red;
                option4Button.BackColor = Color.Green;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (answerCheck(3)==true)
            {
                option3Button.BackColor = Color.Green;
            }
            else if (answerCheck(1) == true)
            {
                option3Button.BackColor = Color.Red;
                option1Button.BackColor = Color.Green;
            }
            else if (answerCheck(2) == true)
            {
                option3Button.BackColor = Color.Red;
                option2Button.BackColor = Color.Green;
            }
            else
            {
                option3Button.BackColor = Color.Red;
                option4Button.BackColor = Color.Green;
            }
            answered = answerCheck(3);

        }

        private void option4Button_Click(object sender, EventArgs e)
        {
            if (answerCheck(4)==true)
            {
                option4Button.BackColor =Color.Green;
            }
            else if (answerCheck(1) == true)
            {
                option4Button.BackColor = Color.Red;
                option1Button.BackColor = Color.Green;
            }
            else if (answerCheck(2) == true)
            {
                option4Button.BackColor = Color.Red;
                option2Button.BackColor = Color.Green;
            }
            else
            {
                option4Button.BackColor = Color.Red;
                option3Button.BackColor = Color.Green;
            }
            answered = answerCheck(4);

        }


    }
}
