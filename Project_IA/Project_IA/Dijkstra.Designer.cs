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
            this.button_init1 = new System.Windows.Forms.Button();
            this.noeudInitial = new System.Windows.Forms.TextBox();
            this.noeudFinal = new System.Windows.Forms.TextBox();
            this.button_Dijkstra = new System.Windows.Forms.Button();
            this.label_NoeudInitial = new System.Windows.Forms.Label();
            this.label_NoeudFinal = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.GraphAleatoirebutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.ToutEnsembleFerme = new System.Windows.Forms.TextBox();
            this.ToutEnsembleOuvert = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_init1
            // 
            this.button_init1.Location = new System.Drawing.Point(821, 508);
            this.button_init1.Name = "button_init1";
            this.button_init1.Size = new System.Drawing.Size(75, 23);
            this.button_init1.TabIndex = 0;
            this.button_init1.Text = "Init_Test";
            this.button_init1.UseVisualStyleBackColor = true;
            this.button_init1.Click += new System.EventHandler(this.button_init1_Click);
            // 
            // noeudInitial
            // 
            this.noeudInitial.Location = new System.Drawing.Point(176, 248);
            this.noeudInitial.Name = "noeudInitial";
            this.noeudInitial.Size = new System.Drawing.Size(100, 20);
            this.noeudInitial.TabIndex = 1;
            this.noeudInitial.Text = "0";
            // 
            // noeudFinal
            // 
            this.noeudFinal.Location = new System.Drawing.Point(316, 247);
            this.noeudFinal.Name = "noeudFinal";
            this.noeudFinal.Size = new System.Drawing.Size(100, 20);
            this.noeudFinal.TabIndex = 2;
            this.noeudFinal.Text = "6";
            // 
            // button_Dijkstra
            // 
            this.button_Dijkstra.Location = new System.Drawing.Point(502, 245);
            this.button_Dijkstra.Name = "button_Dijkstra";
            this.button_Dijkstra.Size = new System.Drawing.Size(152, 23);
            this.button_Dijkstra.TabIndex = 3;
            this.button_Dijkstra.Text = "Soumettre les réponses";
            this.button_Dijkstra.UseVisualStyleBackColor = true;
            this.button_Dijkstra.Click += new System.EventHandler(this.button_Dijkstra_Click);
            // 
            // label_NoeudInitial
            // 
            this.label_NoeudInitial.AutoSize = true;
            this.label_NoeudInitial.Location = new System.Drawing.Point(173, 219);
            this.label_NoeudInitial.Name = "label_NoeudInitial";
            this.label_NoeudInitial.Size = new System.Drawing.Size(65, 13);
            this.label_NoeudInitial.TabIndex = 4;
            this.label_NoeudInitial.Text = "Noeud initial";
            // 
            // label_NoeudFinal
            // 
            this.label_NoeudFinal.AutoSize = true;
            this.label_NoeudFinal.Location = new System.Drawing.Point(313, 219);
            this.label_NoeudFinal.Name = "label_NoeudFinal";
            this.label_NoeudFinal.Size = new System.Drawing.Size(61, 13);
            this.label_NoeudFinal.TabIndex = 5;
            this.label_NoeudFinal.Text = "Noeud final";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(502, 299);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // GraphAleatoirebutton
            // 
            this.GraphAleatoirebutton.Location = new System.Drawing.Point(37, 89);
            this.GraphAleatoirebutton.Name = "GraphAleatoirebutton";
            this.GraphAleatoirebutton.Size = new System.Drawing.Size(99, 23);
            this.GraphAleatoirebutton.TabIndex = 8;
            this.GraphAleatoirebutton.Text = "Graphe aléatoire";
            this.GraphAleatoirebutton.UseVisualStyleBackColor = true;
            this.GraphAleatoirebutton.Click += new System.EventHandler(this.graphAleatoirebutton_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(27, 316);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(127, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // ToutEnsembleFerme
            // 
            this.ToutEnsembleFerme.Location = new System.Drawing.Point(341, 300);
            this.ToutEnsembleFerme.Multiline = true;
            this.ToutEnsembleFerme.Name = "ToutEnsembleFerme";
            this.ToutEnsembleFerme.Size = new System.Drawing.Size(126, 125);
            this.ToutEnsembleFerme.TabIndex = 11;
            this.ToutEnsembleFerme.TextChanged += new System.EventHandler(this.ToutEnsembleFerme_TextChanged);
            // 
            // ToutEnsembleOuvert
            // 
            this.ToutEnsembleOuvert.Location = new System.Drawing.Point(190, 301);
            this.ToutEnsembleOuvert.Multiline = true;
            this.ToutEnsembleOuvert.Name = "ToutEnsembleOuvert";
            this.ToutEnsembleOuvert.Size = new System.Drawing.Size(122, 125);
            this.ToutEnsembleOuvert.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 455);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 35);
            this.textBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(701, 299);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 147);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ensembles Ouverts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ensembles fermées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Arbre d\'exploration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chemin le plus court";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Commentaires";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(259, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToutEnsembleOuvert);
            this.Controls.Add(this.ToutEnsembleFerme);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.GraphAleatoirebutton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label_NoeudFinal);
            this.Controls.Add(this.label_NoeudInitial);
            this.Controls.Add(this.button_Dijkstra);
            this.Controls.Add(this.noeudFinal);
            this.Controls.Add(this.noeudInitial);
            this.Controls.Add(this.button_init1);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_init1;
        private System.Windows.Forms.TextBox noeudInitial;
        private System.Windows.Forms.TextBox noeudFinal;
        private System.Windows.Forms.Button button_Dijkstra;
        private System.Windows.Forms.Label label_NoeudInitial;
        private System.Windows.Forms.Label label_NoeudFinal;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button GraphAleatoirebutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TextBox ToutEnsembleFerme;
        private System.Windows.Forms.TextBox ToutEnsembleOuvert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}