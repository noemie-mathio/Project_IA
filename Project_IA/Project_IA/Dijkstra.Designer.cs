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
            this.button_Dijkstra = new System.Windows.Forms.Button();
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
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.noeud_debut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GraphpictureBox = new System.Windows.Forms.PictureBox();
            this.noeud_fin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Dijkstra
            // 
            this.button_Dijkstra.Location = new System.Drawing.Point(136, 32);
            this.button_Dijkstra.Name = "button_Dijkstra";
            this.button_Dijkstra.Size = new System.Drawing.Size(152, 23);
            this.button_Dijkstra.TabIndex = 3;
            this.button_Dijkstra.Text = "Soumettre les réponses";
            this.button_Dijkstra.UseVisualStyleBackColor = true;
            this.button_Dijkstra.Click += new System.EventHandler(this.button_Dijkstra_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(231, 92);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 112);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(159, 18);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(141, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // ToutEnsembleFerme
            // 
            this.ToutEnsembleFerme.Location = new System.Drawing.Point(157, 54);
            this.ToutEnsembleFerme.Multiline = true;
            this.ToutEnsembleFerme.Name = "ToutEnsembleFerme";
            this.ToutEnsembleFerme.Size = new System.Drawing.Size(126, 125);
            this.ToutEnsembleFerme.TabIndex = 11;
            this.ToutEnsembleFerme.TextChanged += new System.EventHandler(this.ToutEnsembleFerme_TextChanged);
            // 
            // ToutEnsembleOuvert
            // 
            this.ToutEnsembleOuvert.Location = new System.Drawing.Point(11, 55);
            this.ToutEnsembleOuvert.Multiline = true;
            this.ToutEnsembleOuvert.Name = "ToutEnsembleOuvert";
            this.ToutEnsembleOuvert.Size = new System.Drawing.Size(122, 125);
            this.ToutEnsembleOuvert.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 234);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 84);
            this.textBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 82);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ensembles Ouverts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label3.Location = new System.Drawing.Point(228, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Arbre d\'exploration solution :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Commentaires";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(11, 218);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(154, 109);
            this.treeView2.TabIndex = 20;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ajout Noeud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Entrez l\'arbre d\'exploration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 198);
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Supr Noeud";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GraphpictureBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.noeud_fin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.noeud_debut);
            this.groupBox1.Controls.Add(this.listBoxgraphe);
            this.groupBox1.Controls.Add(this.GraphAleatoirebutton);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 168);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "noeud initial";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // noeud_debut
            // 
            this.noeud_debut.Location = new System.Drawing.Point(24, 88);
            this.noeud_debut.Name = "noeud_debut";
            this.noeud_debut.Size = new System.Drawing.Size(100, 20);
            this.noeud_debut.TabIndex = 10;
            this.noeud_debut.TextChanged += new System.EventHandler(this.noeud_debut_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ToutEnsembleFerme);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ToutEnsembleOuvert);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 333);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.button_Dijkstra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(333, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 333);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // GraphpictureBox
            // 
            this.GraphpictureBox.Location = new System.Drawing.Point(342, 21);
            this.GraphpictureBox.Name = "GraphpictureBox";
            this.GraphpictureBox.Size = new System.Drawing.Size(365, 118);
            this.GraphpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GraphpictureBox.TabIndex = 32;
            this.GraphpictureBox.TabStop = false;
            // 
            // noeud_fin
            // 
            this.noeud_fin.Location = new System.Drawing.Point(25, 132);
            this.noeud_fin.Name = "noeud_fin";
            this.noeud_fin.Size = new System.Drawing.Size(100, 20);
            this.noeud_fin.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "noeud final";
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 546);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Dijkstra;
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
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox GraphpictureBox;
        private System.Windows.Forms.TextBox noeud_debut;
        private System.Windows.Forms.TextBox noeud_fin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}