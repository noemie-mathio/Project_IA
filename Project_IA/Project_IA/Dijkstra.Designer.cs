namespace Project_IA
{
    partial class Dijkstra
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoumettreReponses = new System.Windows.Forms.Button();
            this.treeViewSolution = new System.Windows.Forms.TreeView();
            this.GraphAleatoirebutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrapheListBoxgraphe = new System.Windows.Forms.ListBox();
            this.ToutEnsembleFerme = new System.Windows.Forms.TextBox();
            this.ToutEnsembleOuvert = new System.Windows.Forms.TextBox();
            this.commentaireTextBox = new System.Windows.Forms.TextBox();
            this.affichageCheminListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treeViewEtudiant = new System.Windows.Forms.TreeView();
            this.nodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.editNode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boutonConsignes = new System.Windows.Forms.Button();
            this.GraphpictureBox = new System.Windows.Forms.PictureBox();
            this.nf_label = new System.Windows.Forms.Label();
            this.noeud_fin_textbox = new System.Windows.Forms.TextBox();
            this.ni_label = new System.Windows.Forms.Label();
            this.noeud_debut_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSolution = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoumettreReponses
            // 
            this.SoumettreReponses.Location = new System.Drawing.Point(350, 20);
            this.SoumettreReponses.Name = "SoumettreReponses";
            this.SoumettreReponses.Size = new System.Drawing.Size(143, 44);
            this.SoumettreReponses.TabIndex = 3;
            this.SoumettreReponses.Text = "Générer l\'arbre";
            this.SoumettreReponses.UseVisualStyleBackColor = true;
            this.SoumettreReponses.Click += new System.EventHandler(this.button_Dijkstra_Click);
            // 
            // treeViewSolution
            // 
            this.treeViewSolution.ForeColor = System.Drawing.Color.Red;
            this.treeViewSolution.Location = new System.Drawing.Point(215, 92);
            this.treeViewSolution.Name = "treeViewSolution";
            this.treeViewSolution.Size = new System.Drawing.Size(152, 112);
            this.treeViewSolution.TabIndex = 7;
            this.treeViewSolution.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // GraphAleatoirebutton
            // 
            this.GraphAleatoirebutton.Location = new System.Drawing.Point(24, 34);
            this.GraphAleatoirebutton.Name = "GraphAleatoirebutton";
            this.GraphAleatoirebutton.Size = new System.Drawing.Size(99, 23);
            this.GraphAleatoirebutton.TabIndex = 8;
            this.GraphAleatoirebutton.Text = "Graphe aléatoire";
            this.GraphAleatoirebutton.UseVisualStyleBackColor = true;
            this.GraphAleatoirebutton.Click += new System.EventHandler(this.graphAleatoirebutton_Click);
            // 
            // GrapheListBoxgraphe
            // 
            this.GrapheListBoxgraphe.FormattingEnabled = true;
            this.GrapheListBoxgraphe.Location = new System.Drawing.Point(159, 18);
            this.GrapheListBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.GrapheListBoxgraphe.Name = "GrapheListBoxgraphe";
            this.GrapheListBoxgraphe.Size = new System.Drawing.Size(141, 108);
            this.GrapheListBoxgraphe.TabIndex = 9;
            // 
            // ToutEnsembleFerme
            // 
            this.ToutEnsembleFerme.Location = new System.Drawing.Point(157, 54);
            this.ToutEnsembleFerme.Multiline = true;
            this.ToutEnsembleFerme.Name = "ToutEnsembleFerme";
            this.ToutEnsembleFerme.Size = new System.Drawing.Size(126, 125);
            this.ToutEnsembleFerme.TabIndex = 11;
            // 
            // ToutEnsembleOuvert
            // 
            this.ToutEnsembleOuvert.Location = new System.Drawing.Point(11, 55);
            this.ToutEnsembleOuvert.Multiline = true;
            this.ToutEnsembleOuvert.Name = "ToutEnsembleOuvert";
            this.ToutEnsembleOuvert.Size = new System.Drawing.Size(122, 125);
            this.ToutEnsembleOuvert.TabIndex = 12;
            // 
            // commentaireTextBox
            // 
            this.commentaireTextBox.Location = new System.Drawing.Point(413, 101);
            this.commentaireTextBox.Multiline = true;
            this.commentaireTextBox.Name = "commentaireTextBox";
            this.commentaireTextBox.Size = new System.Drawing.Size(364, 84);
            this.commentaireTextBox.TabIndex = 13;
            // 
            // affichageCheminListBox
            // 
            this.affichageCheminListBox.FormattingEnabled = true;
            this.affichageCheminListBox.Location = new System.Drawing.Point(6, 92);
            this.affichageCheminListBox.Name = "affichageCheminListBox";
            this.affichageCheminListBox.Size = new System.Drawing.Size(153, 82);
            this.affichageCheminListBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ensembles Ouverts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ensembles fermées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Arbre d\'exploration solution :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chemin le plus court solution :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Commentaires";
            // 
            // treeViewEtudiant
            // 
            this.treeViewEtudiant.ForeColor = System.Drawing.Color.Black;
            this.treeViewEtudiant.Location = new System.Drawing.Point(350, 70);
            this.treeViewEtudiant.Name = "treeViewEtudiant";
            this.treeViewEtudiant.Size = new System.Drawing.Size(154, 109);
            this.treeViewEtudiant.TabIndex = 20;
            this.treeViewEtudiant.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // nodeTextBox
            // 
            this.nodeTextBox.Location = new System.Drawing.Point(588, 94);
            this.nodeTextBox.Name = "nodeTextBox";
            this.nodeTextBox.Size = new System.Drawing.Size(70, 20);
            this.nodeTextBox.TabIndex = 21;
            this.nodeTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Completez l\'arbre d\'exploration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Entrez le \r\nnoeud ici :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Initialisation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, -8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Vos réponses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, -5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "La solution";
            // 
            // editNode
            // 
            this.editNode.Location = new System.Drawing.Point(578, 181);
            this.editNode.Name = "editNode";
            this.editNode.Size = new System.Drawing.Size(98, 23);
            this.editNode.TabIndex = 28;
            this.editNode.Text = "Editer Noeud";
            this.editNode.UseVisualStyleBackColor = true;
            this.editNode.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boutonConsignes);
            this.groupBox1.Controls.Add(this.GraphpictureBox);
            this.groupBox1.Controls.Add(this.nf_label);
            this.groupBox1.Controls.Add(this.noeud_fin_textbox);
            this.groupBox1.Controls.Add(this.ni_label);
            this.groupBox1.Controls.Add(this.noeud_debut_textbox);
            this.groupBox1.Controls.Add(this.GrapheListBoxgraphe);
            this.groupBox1.Controls.Add(this.GraphAleatoirebutton);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 187);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // boutonConsignes
            // 
            this.boutonConsignes.Location = new System.Drawing.Point(164, 132);
            this.boutonConsignes.Name = "boutonConsignes";
            this.boutonConsignes.Size = new System.Drawing.Size(100, 39);
            this.boutonConsignes.TabIndex = 33;
            this.boutonConsignes.Text = "Consignes";
            this.boutonConsignes.UseVisualStyleBackColor = true;
            this.boutonConsignes.Click += new System.EventHandler(this.boutonConsignes_Click);
            // 
            // GraphpictureBox
            // 
            this.GraphpictureBox.Location = new System.Drawing.Point(342, 21);
            this.GraphpictureBox.Name = "GraphpictureBox";
            this.GraphpictureBox.Size = new System.Drawing.Size(398, 160);
            this.GraphpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GraphpictureBox.TabIndex = 32;
            this.GraphpictureBox.TabStop = false;
            // 
            // nf_label
            // 
            this.nf_label.AutoSize = true;
            this.nf_label.Location = new System.Drawing.Point(21, 111);
            this.nf_label.Name = "nf_label";
            this.nf_label.Size = new System.Drawing.Size(59, 13);
            this.nf_label.TabIndex = 12;
            this.nf_label.Text = "noeud final";
            // 
            // noeud_fin_textbox
            // 
            this.noeud_fin_textbox.Location = new System.Drawing.Point(25, 132);
            this.noeud_fin_textbox.Name = "noeud_fin_textbox";
            this.noeud_fin_textbox.Size = new System.Drawing.Size(100, 20);
            this.noeud_fin_textbox.TabIndex = 11;
            // 
            // ni_label
            // 
            this.ni_label.AutoSize = true;
            this.ni_label.Location = new System.Drawing.Point(24, 69);
            this.ni_label.Name = "ni_label";
            this.ni_label.Size = new System.Drawing.Size(63, 13);
            this.ni_label.TabIndex = 11;
            this.ni_label.Text = "noeud initial";
            // 
            // noeud_debut_textbox
            // 
            this.noeud_debut_textbox.Location = new System.Drawing.Point(24, 88);
            this.noeud_debut_textbox.Name = "noeud_debut_textbox";
            this.noeud_debut_textbox.Size = new System.Drawing.Size(100, 20);
            this.noeud_debut_textbox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSolution);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.editNode);
            this.groupBox2.Controls.Add(this.SoumettreReponses);
            this.groupBox2.Controls.Add(this.ToutEnsembleFerme);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nodeTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.treeViewEtudiant);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ToutEnsembleOuvert);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 241);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // buttonSolution
            // 
            this.buttonSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolution.Location = new System.Drawing.Point(234, 204);
            this.buttonSolution.Name = "buttonSolution";
            this.buttonSolution.Size = new System.Drawing.Size(162, 31);
            this.buttonSolution.TabIndex = 29;
            this.buttonSolution.Text = "Soumettre les réponses";
            this.buttonSolution.UseVisualStyleBackColor = true;
            this.buttonSolution.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 26);
            this.label12.TabIndex = 30;
            this.label12.Text = "Une ligne par étape\r\nSous la forme \"1,2,3..\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(530, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 39);
            this.label11.TabIndex = 29;
            this.label11.Text = "Entre le noeud sous la forme N°Noeud : DistanceTotale\r\nExemple:   0 : 0\r\nN\'oublie" +
    "z pas les espaces de part et d\'autre du \":\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commentaireTextBox);
            this.groupBox3.Controls.Add(this.affichageCheminListBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.treeViewSolution);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 236);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Fin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SoumettreReponses;
        private System.Windows.Forms.TreeView treeViewSolution;
        private System.Windows.Forms.Button GraphAleatoirebutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox GrapheListBoxgraphe;
        private System.Windows.Forms.TextBox ToutEnsembleFerme;
        private System.Windows.Forms.TextBox ToutEnsembleOuvert;
        private System.Windows.Forms.TextBox commentaireTextBox;
        private System.Windows.Forms.ListBox affichageCheminListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeViewEtudiant;
        private System.Windows.Forms.TextBox nodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button editNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox GraphpictureBox;
        private System.Windows.Forms.TextBox noeud_debut_textbox;
        private System.Windows.Forms.TextBox noeud_fin_textbox;
        private System.Windows.Forms.Label ni_label;
        private System.Windows.Forms.Label nf_label;
        private System.Windows.Forms.Button buttonSolution;
        private System.Windows.Forms.Button boutonConsignes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}