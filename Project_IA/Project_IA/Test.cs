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
        public Test()
        {
            InitializeComponent();
        }
        private void newQuestionButton_Click(object sender, EventArgs e)
        {
             List<QuestionsCours> test = QuestionsCours.quizzzzz;
            foreach (QuestionsCours element in QuestionsCours.quizzzzz)
            {
                string question = element.question;
                string reponse1 = element.reponse1;
                string reponse2 = element.reponse2;
                string reponse3 = element.reponse3;
                string reponse4 = element.reponse4;
                string bonnerep = element.bonnereponse;
                string explication = element.explicationBonneReponse;





            }
            if (answered == false)
            {
                return;
            }
            answered = false;

            Song answer1 = question.answer1;
            Song answer2 = question.answer2;
            Song answer3 = question.answer3;

            option1Button.Text = answer1.artist;
            option2Button.Text = answer2.artist;
            option3Button.Text = answer3.artist;

            answerNum = random.Next(1, 4);
            if (answerNum == 1)
                correctAnswer = answer1;
            else if (answerNum == 2)
                correctAnswer = answer2;
            else
                correctAnswer = answer3;

            player = new Player(correctAnswer.path);
            songTimer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
