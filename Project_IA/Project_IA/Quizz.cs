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
        int bonnereponse;
        int score;
        int compteur = 0;
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
            option1Button.Enabled = true;
            option2Button.Enabled = true;
            option3Button.Enabled = true;
            option4Button.Enabled = true;
            buttonNext.Visible = false;

        }
        private bool answerCheck(int answerNumber)
        {
            option1Button.Enabled = false;
            option2Button.Enabled = false;
            option3Button.Enabled = false;
            option4Button.Enabled = false;
            buttonNext.Visible = true;
            if(answerNumber==this.bonnereponse)
            {
                 
                return true;       
            }
            else
            {
                return false;
            }
        }
        

        private void option1Button_Click(object sender, EventArgs e)
        { 
            if(answerCheck(1)==true)
            {
                option1Button.BackColor =Color.Green;
                score++;
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
            if (answerCheck(1) == false)
            {
                MessageBox.Show(quizzzzz.ElementAt(compteur).explicationBonneReponse);
            }
            compteur++;
        }
        private void defaultBackColor()
        {
            option1Button.BackColor = Control.DefaultBackColor;
            option2Button.BackColor = Control.DefaultBackColor;
            option3Button.BackColor = Control.DefaultBackColor;
            option4Button.BackColor = Control.DefaultBackColor;


        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (answerCheck(2) == true)
            {
                option2Button.BackColor = Color.Green;
                score++;

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
            if (answerCheck(2) == false)
            {
                MessageBox.Show(quizzzzz.ElementAt(compteur).explicationBonneReponse);
            }
            compteur++;
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (answerCheck(3)==true)
            {
                option3Button.BackColor = Color.Green;
                score++;

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
            if (answerCheck(3) == false)
            {
                MessageBox.Show(quizzzzz.ElementAt(compteur).explicationBonneReponse);
            }
            compteur++;
        }

        private void option4Button_Click(object sender, EventArgs e)
        {
            if (answerCheck(4)==true)
            {
                option4Button.BackColor =Color.Green;
                score++;
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
            if (answerCheck(4) == false)
            {
                if (answerCheck(1) == false)
                {
                    MessageBox.Show(quizzzzz.ElementAt(compteur).explicationBonneReponse);
                }
            }
            compteur++;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (compteur<20)
            {
                defaultBackColor();
                newQuestion();
                labelScore.Text = "SCORE :" + score + "/" + compteur;
            }
           else
            {
                MessageBox.Show("Votre score final est :" + score + "/" + compteur);
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
        }

        
    }
}
