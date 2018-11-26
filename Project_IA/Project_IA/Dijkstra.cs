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



/// <summary>
/// quelques modifications à faire : supprimer les Ajouts Ouverts qui ne servent à rien.
/// gérer les exceptions.
/// empecher l'affichage de la solution si l'étudiant ne rentre aucun ensemble ouvert et fermé
/// Tester avec les bons ensembles ouverts et fermés
/// retirer le premier ensemble des fermées car il est vide ?
/// </summary>

namespace Project_IA
{
    public partial class Dijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public List<int> NbrAjoutOuvert;
        public List<GenericNode> Ouvert;
        static public List<int> EnsembleOuvertEleve;
        static public List<int> NbrAjoutOuvertEleve;
        static public List<int> EnsembleFermesEleve;
        static public List<GenericNode> L_Ouverts;
        static public List<GenericNode> L_Fermes;
        static public List<GenericNode> N0List;
        static public List<List<GenericNode>> EnsembleOuvert;
        public Image imageGraphe;
        static bool juste;
        private object ImageWindow;

        public Dijkstra()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void button_init1_Click(object sender, EventArgs e)
        {

            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3; matrice[1, 0] = 3;
            matrice[0, 2] = 5; matrice[2, 0] = 5;
            matrice[0, 3] = 7; matrice[3, 0] = 7;
            matrice[1, 4] = 8; matrice[4, 1] = 8;
            matrice[2, 4] = 3; matrice[4, 2] = 3;
            matrice[4, 5] = 7; matrice[5, 4] = 7;
            matrice[5, 6] = 4; matrice[6, 5] = 4;
        }

        private void button_Dijkstra_Click(object sender, EventArgs e)
        {

            numinitial = Convert.ToInt32(noeudInitial.Text);
            numfinal = Convert.ToInt32(noeudFinal.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;

            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();
            EnsembleOuvert = new List<List<GenericNode>>();
            N0List = new List<GenericNode>();
            NbrAjoutOuvert = new List<int>();
            Ouvert = new List<GenericNode>();
            EnsembleOuvertEleve = new List<int>();   
            NbrAjoutOuvertEleve = new List<int>();
            EnsembleFermesEleve = new List<int>();  
            
            // Le noeud passé en paramètre est supposé être le noeud initial
            GenericNode N = N0;
            N0List.Add(N0);
            L_Ouverts.Add(N0);
            EnsembleOuvert.Add(N0List);

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState() == false)
            {
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Fermes.Add(N);
                L_Ouverts.Remove(N);
                GenericNode solu = g.stepSolutionAEtoile(N, L_Ouverts, L_Fermes);
                EnsembleOuvert.Add(L_Ouverts); // comment utiliser la méthode MAjsuccesseur
                N = solu;
                //  NbrAjoutOuvert.Add(L_Ouverts.Count); 
            }
            // renvois les noeuds parents jusqu'a avoir l'arbre total methode du SearchTree qui est passé en ligne de code directement.
            List<GenericNode> _LN = new List<GenericNode>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    _LN.Insert(0, N);  // On insère en position 1
                }
            }
            List<GenericNode> solution = _LN;
            ///////////////////////////////////////////////  Lecture des réponses de l'étudiant   /////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////     Lecture des ensembles ouverts     ///////////////

            int lignes = 0;


            while (lignes < ToutEnsembleOuvert.Lines.Length)
            {
                String ligne = ToutEnsembleOuvert.Lines[lignes];
                int j = 0;
                int compt = 0;
                while (j < ToutEnsembleOuvert.Lines[lignes].Length)
                {
                    if (ligne[j] != ',')
                    {
                        compt++;
                        EnsembleOuvertEleve.Add(Convert.ToInt32(ligne[j]));
                        j++;
                    }
                    else j++;
                }
                NbrAjoutOuvertEleve.Add(compt);
                lignes++;
            }
            
            ////////////////// cas où l'eleve mets tous les ensembles fermés

            
            int lignesF = 0;

            
            while (lignesF < ToutEnsembleFerme.Lines.Length)
            {
                String ligneF = ToutEnsembleFerme.Lines[lignesF];
                int j = 0;
                int compt = 0;
                while (j < ligneF.Length)
                {
                    if (ligneF[j] != ',')
                    {
                        compt++;
                        EnsembleFermesEleve.Add(Convert.ToInt32(ligneF[j]));
                        j++;
                    }
                    else j++;
                }
                
                lignesF++;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////               à partir de là nous pouvons commencer à comparer les ensembles.                     //////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////// Comparaison des Ensembles ouverts //////////////////////////
            juste = true;
            int CompteurO = 0;
            if (ToutEnsembleOuvert.Lines.Length == 0)
            {
                textBox1.Text = ("Vous devez remplir les ensembles Ouverts au format 1,2,3... \r\n");
            }
            else
            {
                while (CompteurO < EnsembleOuvert.Count && juste == true)
                {

                    if (EnsembleOuvert[CompteurO].Count == ToutEnsembleOuvert.Lines[CompteurO].Length)
                    {
                        Ouvert = EnsembleOuvert.ElementAt(CompteurO);
                        int i = 0;
                        while (i < Ouvert.Count && juste == true)
                        {

                            Node2 OuvertBis = (Node2)Ouvert[i];
                            string LigneEnsOuv = ToutEnsembleOuvert.Lines[CompteurO];
                            if ((OuvertBis.getNumero() == LigneEnsOuv[i].ToString()) && juste == true)
                            { juste = true; }
                            else
                            { juste = false; }
                            i++;
                        }
                        CompteurO++;
                    }
                    else
                    { juste = false; }

                    CompteurO++;
                }

                if (juste == false)
                {
                    textBox1.Text = ("Vous vous etes trompé dans l'ensemble ouvert à l'étape :" + CompteurO + "\r\n");
                }
                else
                { textBox1.Text = ("Bravo, vous avez bien trouvé l'ensemble des ouverts \r\n"); }
            }
            // fin du test des ensembles ouverts dans l'ordre
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Test des ensembles fermés (toujours dans l'Ordre car si la personne les mets dans le désordre c'est qu'elle n'a pas compris le Dijkstra
            juste = true;
            int CompteurF = 0;
            string LigneEnsFerm = "";
            if (ToutEnsembleFerme.Lines.Length == 0)
            {
               textBox1.Text += ("Vous devez remplir les ensembles Fermés au format 1,2,3... \r\n");
            }
            else
            {
                while ((CompteurF < L_Fermes.Count && juste == true) && (ToutEnsembleFerme.Lines.Length != 0))
                {
                    LigneEnsFerm = ToutEnsembleFerme.Lines[CompteurF];
                    if (L_Fermes.Count == ToutEnsembleFerme.Lines.Length - 1)
                    {

                        int i = 0;
                        while (i < LigneEnsFerm.Length && juste == true)
                        {
                            Node2 FermeBis = (Node2)L_Fermes[i];

                            if ((FermeBis.getNumero() == LigneEnsFerm[i].ToString()) && juste == true)
                            {
                                juste = true;
                            }
                            else
                            {
                                juste = false;
                            }
                            i++;
                        }
                        CompteurF++;
                    }


                    else
                    {
                        juste = false;
                    }
                    CompteurF++;
                }


                if (juste == false)
                {
                    textBox1.Text += ("Vous vous etes trompé dans l'ensemble ferme à l'étape :" + CompteurF + "\r\n");
                }
                else if (ToutEnsembleFerme.Lines.Length != 0)
                {
                    textBox1.Text += ("Bravo, vous avez bien trouvé l'ensemble des fermées \r\n");
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////    fin des tests sur les ensembles ouverts et fermés    ////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            /// affichage de l'arbre des solutions et du chemin le plus court à condition que l'étudiant ait entré des ensembles ouverts et fermés

            Node2 N1 = N0;
            if ((ToutEnsembleFerme.Lines.Length != 0) && (ToutEnsembleOuvert.Lines.Length != 0))
            {
                for (int i = 1; i < solution.Count; i++)
                {
                    Node2 N2 = (Node2)solution[i];
                    listBox1.Items.Add(Convert.ToString(N1.numero)
                         + "--->" + Convert.ToString(N2.numero)
                         + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                    N1 = N2;
                }

                g.GetSearchTree(treeView1);
            }

        }

        private void graphAleatoirebutton_Click(object sender, EventArgs e)
        {
            listBoxgraphe.Items.Clear();

            Random random = new Random();
            StreamReader monStreamReader = new StreamReader("graphe.txt");
            string ligne = monStreamReader.ReadLine();
            int compteurDijkstra = 0; // Compte le nombre de graph différent dans le fichier
            while (ligne != null)
            {
                ligne = monStreamReader.ReadLine();
                if (ligne == "fin")
                {
                    compteurDijkstra++;
                }

            }
            monStreamReader = new StreamReader("graphe.txt");
            //choix au hasard du graph à étudier parmi le nombre de graph total.
            int choixGraph = random.Next(1,compteurDijkstra + 1);
            imageGraphe = Image.FromFile("image" + choixGraph + ".jpg");

            // On réinitialise la lecture du fichier
            ligne = monStreamReader.ReadLine();
            int compteurDijkstra2 = 0;
            while (compteurDijkstra2 != choixGraph-1)
            {
                ligne = monStreamReader.ReadLine();
                if (ligne == "fin")
                {
                    compteurDijkstra2++;
                }
            }
            if (choixGraph != 1)
            {
                ligne = monStreamReader.ReadLine();
            }

            int i = 0;
            while (ligne[i].Equals(':')!=true) { i++; }
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i].Equals(' ')) { i++; }// on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
            {
                for (int j = 0; j < nbnodes; j++)
                {
                    matrice[i, j] = -1;
                }
            }

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne.Equals("fin")!=true)
            {
                i = 0;
                while (ligne[i].Equals(':') != true) { i++; }
                i++; // on passe le :
                while (ligne[i].Equals(' ')) { i++; } // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i].Equals(' ') != true)
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i].Equals(' ')) { i++; }
                string strN2 = "";
                while (ligne[i].Equals(' ') != true)
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i].Equals(' ')) { i++; }
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
                

            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
           // pictureBox1.Width = imageGraphe.Width;
            //pictureBox1.Height = imageGraphe.Height;
            pictureBox1.Image = imageGraphe;
            pictureBox1.Visible = true;

        }
        public List<GenericNode> cheminParcoursArbre(GenericNode N, GenericNode N0)
        {

            List<GenericNode> _LN = new List<GenericNode>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    _LN.Insert(0, N);  // On insère en position 1
                }
            }
            return _LN;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToutEnsembleFerme_TextChanged(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, EventArgs e) { }




    }
}