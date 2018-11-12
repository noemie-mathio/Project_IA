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

        private void button2_Click(object sender, EventArgs e)
        {
            Quizz QCM = new Quizz();
            QCM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dijkstra Dijkstra = new Dijkstra();
            Dijkstra.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NouvelleQuestion AjoutNouvelleQuestion = new NouvelleQuestion();
            AjoutNouvelleQuestion.Show();
            this.Hide();
        }
    }
}
