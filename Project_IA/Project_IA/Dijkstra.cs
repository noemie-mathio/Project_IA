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
/// Tester avec les bons ensembles ouverts et fermés
/// /// préciser que le graphe n'a pas été chargé. dans le bouton init, mettre une variable
/// </summary>

namespace Project_IA
{
    public partial class Dijkstra : Form
    {
        private bool quizz;
        private int question1=0;
        private int compteurQuestion2=0;

        static public int[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public int ensembleFermeEleve;
        static public int ensembleOuvertEleve;

        public List<GenericNode> Ouvert;
        public List<GenericNode> Fermes;
        static public List<List<string>> EnsembleOuvertEleve;
        static public List<List<string>> EnsembleFermeEleve;
        static public List<GenericNode> L_Ouverts;
        static public List<GenericNode> L_Fermes;
        static public List<GenericNode> N0List;
        static public List<List<GenericNode>> EnsembleOuvert;
        static public List<List<GenericNode>> EnsembleFermes;
        public Image imageGraphe;
        public static bool juste;
        public List<GenericNode> solution;
        public Node2 N0;
        private SearchTree g;

        public Dijkstra()
        {
            InitializeComponent();
            GraphpictureBox.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            nf_label.Visible = false;
            ni_label.Visible = false;
            noeud_debut_textbox.Visible = false;
            noeud_fin_textbox.Visible = false;
            boutonConsignes.Visible = false;
            GrapheListBoxgraphe.Visible = false;
        }
        public Dijkstra(bool boolean)
        {
            quizz = boolean;

            InitializeComponent();
            GraphpictureBox.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            nf_label.Visible = false;
            ni_label.Visible = false;
            noeud_debut_textbox.Visible = false;
            noeud_fin_textbox.Visible = false;
            boutonConsignes.Visible = false;
            GrapheListBoxgraphe.Visible = false;
        }

        private void button_Dijkstra_Click(object sender, EventArgs e)
        {
            affichageCheminListBox.Items.Clear();
            commentaireTextBox.Clear();
            string message = "ERREUR \r\n";
            try
            {
                numinitial = Convert.ToInt32(noeud_debut_textbox.Text);
            }
            catch
            {
                message += ("Vous n'avez pas entré de noeud initial \r\n");
            }
            try
            {
                numfinal = Convert.ToInt32(noeud_fin_textbox.Text);
            }
            catch
            {
                message += ("Vous n'avez pas entré de noeud final \r\n");
            }
            if (message == "ERREUR \r\n")
            {
                g = new SearchTree();
                N0 = new Node2();
                N0.numero = numinitial;

                L_Ouverts = new List<GenericNode>();
                L_Fermes = new List<GenericNode>();
                EnsembleOuvert = new List<List<GenericNode>>();
                EnsembleFermes = new List<List<GenericNode>>();
                N0List = new List<GenericNode>();



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
                    List<GenericNode> listOuvert = new List<GenericNode>(L_Ouverts);
                    EnsembleOuvert.Add(listOuvert);
                    List<GenericNode> listFermes = new List<GenericNode>(L_Fermes);
                    EnsembleFermes.Add(listFermes);
                    N = solu;

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
                solution = _LN;


                g.PrintEmptyTree(treeViewEtudiant);
            }
            else { MessageBox.Show(message); }
            

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////               à partir de là nous pouvons commencer à comparer les ensembles.                     //////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////    fin des tests sur les ensembles ouverts et fermés    ////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            /// affichage de l'arbre des solutions et du chemin le plus court à condition que l'étudiant ait entré des ensembles ouverts et fermés
        }
            public void affichageSolution(Node2 N0,List<GenericNode> solution)
        {
            EnsembleOuvertEleve = new List<List<string>>();
            EnsembleFermeEleve = new List<List<string>>();
            Ouvert = new List<GenericNode>();
           
            ///////////////////////////////////////////////  Lecture des réponses de l'étudiant   /////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////     Lecture des ensembles ouverts     ///////////////

            int lignes = 0;
            List<string> LigneENsOuvElev = new List<string>();
            while (lignes < ToutEnsembleOuvert.Lines.Length)
            {
                String ligne = ToutEnsembleOuvert.Lines[lignes];
                int j = 0;
                LigneENsOuvElev = new List<string>();
                while (j < ToutEnsembleOuvert.Lines[lignes].Length)
                {
                    if (ligne[j] != ',')
                    {

                        LigneENsOuvElev.Add(ligne[j].ToString());
                        j++;
                    }
                    else { j++; }
                }
                EnsembleOuvertEleve.Add(LigneENsOuvElev);
                lignes++;
            }

            ////////////////// cas où l'eleve mets tous les ensembles fermés


            int lignesF = 0;
            List<string> LigneENsFerElev = new List<string>();
            while (lignesF < ToutEnsembleFerme.Lines.Length)
            {
                String ligne = ToutEnsembleFerme.Lines[lignesF];
                int j = 0;
                LigneENsFerElev = new List<string>();
                while (j < ToutEnsembleFerme.Lines[lignesF].Length)
                {
                    if (ligne[j] != ',')
                    {

                        LigneENsFerElev.Add(ligne[j].ToString());
                        j++;
                    }
                    else { j++; }
                }
                EnsembleFermeEleve.Add(LigneENsFerElev);
                lignesF++;
            }
            Node2 N1 = N0;
                if ((ToutEnsembleFerme.Lines.Length != 0) && (ToutEnsembleOuvert.Lines.Length != 0))
                {
                    if (Convert.ToInt32(noeud_fin_textbox.Text) > nbnodes)
                    {
                        commentaireTextBox.Text += ("Le noeud final stipulé est plus grand que le nombre de noeuds total");
                    }
                    else
                    {
                        for (int i = 1; i < solution.Count; i++)
                        {
                            Node2 N2 = (Node2)solution[i];
                            affichageCheminListBox.Items.Add(Convert.ToString(N1.numero)
                                 + "--->" + Convert.ToString(N2.numero)
                                 + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                            N1 = N2;
                        }

                        g.GetSearchTree(treeViewSolution);
                    }
                }
                    ComparerTreeViews(treeViewSolution, treeViewEtudiant);  // comparaison des treeView. Nous essayons de modifier la couleur de police au fur et à mesure

                    if (treeViewSolution.Nodes.Count == 0)
                    {
                        commentaireTextBox.Text += "Vous n'avez pas rempli l'arbre d'exploration\r\n";
                    }
                    else
                    {
                        ComparerTreeViews(treeViewSolution, treeViewEtudiant);
                    }
            //////////////////////// Comparaison des Ensembles ouverts //////////////////////////
            juste = true;
            int CompteurO = 0;
          
                while ((CompteurO < Math.Min(EnsembleOuvert.Count, EnsembleOuvertEleve.Count)) && (juste == true))
                {

                    Ouvert = EnsembleOuvert.ElementAt(CompteurO);
                    List<string> LigneEnsOuv = EnsembleOuvertEleve.ElementAt(CompteurO);

                    if (Ouvert.Count == LigneEnsOuv.Count)
                    {

                        int i = 0;
                        while (i < Ouvert.Count && juste == true)
                        {

                            Node2 OuvertBis = (Node2)Ouvert[i];
                            int j = 0;
                            juste = false;               // tant que la ligne ne contient pas de bonne réponse, on considere que c'est faut. On retourne donc faut si dans la ligne il n'y a pas la bonne réponse.
                            while (j < Ouvert.Count)
                            {
                                if (OuvertBis.getNumero() == LigneEnsOuv[j])
                                {
                                    juste = true;
                                }
                                j++;
                            }
                            i++;
                        }

                    }

                    else
                    {
                        juste = false;
                    }
                    CompteurO++;
                }

                if (juste == true)
                {
                question1++;
                    commentaireTextBox.Text += ("Bravo, vous avez bien trouvé l'ensemble des ouverts \r\n");
                }
                else if (juste == false)
                { commentaireTextBox.Text += ("Vous vous etes trompé dans l'ensemble ouvert à l'étape :" + CompteurO + "\r\n"); }
            
            
            // fin du test des ensembles ouverts dans l'ordre
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Test des ensembles fermés (toujours dans l'Ordre car si la personne les mets dans le désordre c'est qu'elle n'a pas compris le Dijkstra
            juste = true;
            int CompteurF = 0;
          
            
                while ((CompteurF < Math.Min(L_Fermes.Count, EnsembleFermeEleve.Count)) && (juste == true))
                {

                    Fermes = EnsembleFermes.ElementAt(CompteurF);
                    List<string> LigneEnsFer = EnsembleFermeEleve.ElementAt(CompteurF);

                    if (Fermes.Count == LigneEnsFer.Count)
                    {

                        int i = 0;
                        while (i < Fermes.Count && juste == true)
                        {

                            Node2 FermeBis = (Node2)Fermes[i];
                            int j = 0;
                            juste = false;               // tant que la ligne ne contient pas de bonne réponse, on considere que c'est faut. On retourne donc faut si dans la ligne il n'y a pas la bonne réponse.
                            while (j < Fermes.Count)
                            {
                                if (FermeBis.getNumero() == LigneEnsFer[j])
                                {
                                    juste = true;
                                }
                                j++;
                            }
                            i++;
                        }

                    }

                    else
                    {
                        juste = false;
                    }
                    CompteurF++;
                }

                if (juste == true)
                {
                question1++;
                    commentaireTextBox.Text += ("Bravo, vous avez bien trouvé l'ensemble des fermes \r\n");
                }
                else if (juste == false)
                { commentaireTextBox.Text += ("Vous vous etes trompé dans l'ensemble ferme à l'étape :" + CompteurF + "\r\n"); }

            

        }
        void ComparerTreeNodes(TreeNode node1, TreeNode node2)
           {
            if (node1.Text != node2.Text) //réponse incorrecte
            {
                node1.ForeColor = Color.Red;
                node2.ForeColor = Color.Red;
            }

            if (node1.Text == node2.Text) // réponse correcte
            {
                node1.ForeColor = Color.Green;
                node2.ForeColor = Color.Green;
                compteurQuestion2++;
            }

            if (node2.Text == null) // l'étudiant à oublier un noeud
            {
                node1.ForeColor = Color.Red;
            }

            if (node1.Text == null) // l'étudiant à mis trop de noeuds
            {
                node2.ForeColor = Color.Red;
            }
            for (int i = 0; i < node1.Nodes.Count; i++)
            {
                ComparerTreeNodes(node1.Nodes[i], node2.Nodes[i]);
            }
            
        }

        void ComparerTreeViews(TreeView tv1, TreeView tv2)
        {
            // Parcourons tous les noeuds, meme ceux qui sont en trop
            
            for (int i = 0; i < tv1.Nodes.Count; i++)
            {
                ComparerTreeNodes(tv1.Nodes[i], tv2.Nodes[i]);
            }
        }

        private void graphAleatoirebutton_Click(object sender, EventArgs e)
        {

            GraphpictureBox.Visible = true;
            groupBox2.Visible = true;
            nf_label.Visible = true;
            ni_label.Visible = true;
            noeud_debut_textbox.Visible = true;
            noeud_fin_textbox.Visible = true;
            boutonConsignes.Visible = true;
            GrapheListBoxgraphe.Visible = true;
            GrapheListBoxgraphe.Items.Clear();

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

            matrice = new int[nbnodes, nbnodes];
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
                int val = int.Parse(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                GrapheListBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
                

            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();


            //////////////// initialisation du Treeview

           // treeView2.NodeMouseintClick;
            //TreeNode treeNode = new TreeNode("noeudInitial.numero");
            //      treeView2.Nodes.Add(treeNode);
            //      treeView2.Nodes.Clear();
            //     TreeNode node2 = new TreeNode("C#");
            //      TreeNode node3 = new TreeNode("VB.NET");
            //       TreeNode[] array = new TreeNode[] { node2, node3 };
            //      treeNode = new TreeNode("noeudInitial", array);
            //      treeView2.Nodes.Add(treeNode);

           
            GraphpictureBox.Image = imageGraphe;
            GraphpictureBox.Visible = true;


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

      

        private void treeView1_AfterSelect(object sender, EventArgs e) { }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodeTextBox.Text=treeViewEtudiant.SelectedNode.Text;
            treeViewEtudiant.ExpandAll();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(nodeTextBox.Text);
           try {
                treeViewEtudiant.SelectedNode.Nodes.Add(node); }
            catch { treeViewEtudiant.Nodes.Add(node); }
            treeViewEtudiant.ExpandAll();
        }
   
       

        private void button2_Click(object sender, EventArgs e)
        {
           
                treeViewEtudiant.SelectedNode.Text=nodeTextBox.Text;
           
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "ATTENTION \r\n";
           
            if (ToutEnsembleOuvert.Text=="")
            {
                message += ("Vous devez remplir les ensembles Ouverts au format 1,2,3... \r\n");
            }
            if (ToutEnsembleFerme.Text=="")
            {
                message += ("Vous devez remplir les ensembles Fermés au format 1,2,3... \r\n");
            }
            if (treeViewEtudiant.Nodes.Count == 0)
            {
                message += ("Vous devez remplir l'arbre d'exploration en cliquant sur générer l'arbre puis en éditant les noeuds\r\n");
            }
            if(message== "ATTENTION \r\n")
            {

                groupBox3.Visible = true;
                affichageSolution(N0, solution);
            }
            else { MessageBox.Show(message); }
            
        }

        private void boutonConsignes_Click(object sender, EventArgs e)
        {
            string message="";
            try
            {
                numinitial = Convert.ToInt32(noeud_debut_textbox.Text);
            }
            catch
            {
                message += ("Vous devez entrer un noeud initial \r\n");
            }
            try
            {
                numfinal = Convert.ToInt32(noeud_fin_textbox.Text);
            }
            catch
            {
                message += ("Vous devez entrer un noeud final \r\n");
            }
            try
            {
                ensembleFermeEleve = Convert.ToInt32(ToutEnsembleFerme.Text);
            }
            catch
            {
                message += ("Vous devez remplir les ensembles Fermés au format 1,2,3... \r\n");
            }
            try
            {
                ensembleOuvertEleve= Convert.ToInt32(ToutEnsembleOuvert.Text);
            }
            catch
            {
                message += ("Vous devez remplir les ensembles Ouverts au format 1,2,3... \r\n");
            }
            
            
            if (treeViewSolution.Nodes.Count == 0)
            {
                message += ("Vous devez remplir l'arbre d'exploration en cliquant sur générer l'arbre puis en éditant les noeuds\r\n");
                message += ("Les noeuds doivent être sous la forme 0:0, 1:3");
            }
           
            if (message!="")
            {
                MessageBox.Show(message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (quizz==false)
            {
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
            else
            {
                if (question1==2 && compteurQuestion2== treeViewSolution.Nodes.Count)
                {
                    Quizz quizz = new Quizz(3);
                    quizz.Show();
                    this.Hide();
                }
                else if (question1!=2 && compteurQuestion2 != 0 &&compteurQuestion2 == treeViewSolution.GetNodeCount(true))
                {
                    Quizz quizz = new Quizz(1);
                    quizz.Show();
                    this.Hide();
                }
                else if (question1 == 2 && compteurQuestion2 != treeViewSolution.Nodes.Count)
                {
                    Quizz quizz = new Quizz(2);
                    quizz.Show();
                    this.Hide();
                }
                else
                {
                    Quizz quizz = new Quizz(0);
                    quizz.Show();
                    this.Hide();
                }
            }
        }
    }
}