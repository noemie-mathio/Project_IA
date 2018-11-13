using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IA
{
    public partial class NouveauDijkstra : Form
    {
        string fichierOrigine;

        public NouveauDijkstra()
        {
            InitializeComponent();
            chargementImageOklabel.Visible = false;
            erreurLabel.Visible = false;
        }


        private void chargementGraphButton_Click(object sender, EventArgs e)
        {
            if (this.imageDijkstraOpenFileDialog1.ShowDialog() == DialogResult.OK) //On rentre dans le IF seulement si l'utilisateur à cliqué OK
            {
                fichierOrigine = this.imageDijkstraOpenFileDialog1.FileName;
                chargementImageOklabel.Visible = true;
            }
        }

        private void envoyerButton_Click(object sender, EventArgs e)
        {
            if (dijkstraTextBox.Text != "" && fichierOrigine !=null)
            {

                StreamReader monStreamReader = new StreamReader("graphe.txt");
                string ligne = monStreamReader.ReadLine();
                int compteurDijkstra = 0;
                while(ligne!= null)
                {
                    ligne = monStreamReader.ReadLine();
                    if (ligne=="fin")
                    {
                        compteurDijkstra++;
                    }
                    
                }
                monStreamReader.Close();
                string fichierCopie = Path.GetFileName("image"+ (compteurDijkstra+1).ToString()+".jpg");//Pensez à le renommer suivant le numéro de Dijkstra auquel il correspond
                File.Copy(fichierOrigine, fichierCopie);
                File.AppendAllText("graphe.txt", "\r\n" + dijkstraTextBox.Text);
                File.AppendAllText("graphe.txt", "\r\n" + "fin");// pensez à modifier le fichier en fonction 
            }
            else
            {
                erreurLabel.BackColor = Color.Red;
                erreurLabel.Visible = true;
            }
            
        }

        
    }
}
