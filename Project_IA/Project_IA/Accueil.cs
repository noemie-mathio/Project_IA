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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            Quizz QCM = new Quizz();
            QCM.Show();
            this.Hide();
        }

        private void dijkstraButton_Click(object sender, EventArgs e)
        {
            Dijkstra Dijkstra = new Dijkstra();
            Dijkstra.Show();
            this.Hide();
        }

        private void ajoutQuizButton_Click(object sender, EventArgs e)
        {
            NouvelleQuestionQuiz AjoutNouvelleQuestion = new NouvelleQuestionQuiz();
            AjoutNouvelleQuestion.Show();
            this.Hide();
        }

        private void ajoutDijkstraButton_Click(object sender, EventArgs e)
        {
            NouveauDijkstra NouveauDijkstra = new NouveauDijkstra();
            NouveauDijkstra.Show();
            this.Hide();
        }
    }
}
