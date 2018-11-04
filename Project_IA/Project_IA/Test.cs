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
    public partial class Test : Form
    {
        string question;
        string reponse1;
        string reponse2;
        string reponse3;
        string reponse4;
        int bonnerep;
        string explication;
        bool reponse;
        int score;
        public Test()
        {
            InitializeComponent();
            score = 0;

        }
        private void newQuestionButton_Click(object sender, EventArgs e)
        {
             List<QuestionsCours> test = QuestionsCours.quizzzzz;
            foreach (QuestionsCours element in QuestionsCours.quizzzzz)
            {
                 question = element.question;
                 reponse1 = element.reponse1;
                 reponse2 = element.reponse2;
                 reponse3 = element.reponse3;
                 reponse4 = element.reponse4;
                 bonnerep = element.bonnereponse;
                 explication = element.explicationBonneReponse;
                
  
            }
           
            option1Button.Text = reponse1;
            option2Button.Text = reponse2;
            option3Button.Text = reponse3;
            option4Button.Text = reponse4;

           
        }
        private bool verificationQuestion(int nbDeLaReponse)
        {
            if (nbDeLaReponse == this.bonnerep)
            {
                score++;                
                scoreLabel.Text = "Score: " + score.ToString();
                MessageBox.Show("Bonne réponse");
                return true;
            }
            else
            {
                MessageBox.Show("Faux");
                return false;
            }
        }
        private void option1Button_Click(object sender, EventArgs e)
        {
            reponse = verificationQuestion(1);
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            reponse = verificationQuestion(2);

        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            reponse = verificationQuestion(3);

        }
        private void option4Button_Click(object sender, EventArgs e)
        {
            reponse = verificationQuestion(4);

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        
    }
}
