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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button_init2 = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button_init1
            // 
            this.button_init1.Location = new System.Drawing.Point(35, 22);
            this.button_init1.Name = "button_init1";
            this.button_init1.Size = new System.Drawing.Size(75, 23);
            this.button_init1.TabIndex = 0;
            this.button_init1.Text = "Init1";
            this.button_init1.UseVisualStyleBackColor = true;
            this.button_init1.Click += new System.EventHandler(this.button_init1_Click);
            // 
            // noeudInitial
            // 
            this.noeudInitial.Location = new System.Drawing.Point(171, 38);
            this.noeudInitial.Name = "noeudInitial";
            this.noeudInitial.Size = new System.Drawing.Size(100, 20);
            this.noeudInitial.TabIndex = 1;
            this.noeudInitial.Text = "0";
            this.noeudInitial.TextChanged += new System.EventHandler(this.noeudInitial_TextChanged);
            // 
            // noeudFinal
            // 
            this.noeudFinal.Location = new System.Drawing.Point(311, 38);
            this.noeudFinal.Name = "noeudFinal";
            this.noeudFinal.Size = new System.Drawing.Size(100, 20);
            this.noeudFinal.TabIndex = 2;
            this.noeudFinal.Text = "6";
            this.noeudFinal.TextChanged += new System.EventHandler(this.noeudFinal_TextChanged);
            // 
            // button_Dijkstra
            // 
            this.button_Dijkstra.Location = new System.Drawing.Point(479, 22);
            this.button_Dijkstra.Name = "button_Dijkstra";
            this.button_Dijkstra.Size = new System.Drawing.Size(75, 23);
            this.button_Dijkstra.TabIndex = 3;
            this.button_Dijkstra.Text = "A*";
            this.button_Dijkstra.UseVisualStyleBackColor = true;
            this.button_Dijkstra.Click += new System.EventHandler(this.button_Dijkstra_Click);
            // 
            // label_NoeudInitial
            // 
            this.label_NoeudInitial.AutoSize = true;
            this.label_NoeudInitial.Location = new System.Drawing.Point(168, 9);
            this.label_NoeudInitial.Name = "label_NoeudInitial";
            this.label_NoeudInitial.Size = new System.Drawing.Size(65, 13);
            this.label_NoeudInitial.TabIndex = 4;
            this.label_NoeudInitial.Text = "Noeud initial";
            this.label_NoeudInitial.Click += new System.EventHandler(this.label_NoeudInitial_Click);
            // 
            // label_NoeudFinal
            // 
            this.label_NoeudFinal.AutoSize = true;
            this.label_NoeudFinal.Location = new System.Drawing.Point(308, 9);
            this.label_NoeudFinal.Name = "label_NoeudFinal";
            this.label_NoeudFinal.Size = new System.Drawing.Size(61, 13);
            this.label_NoeudFinal.TabIndex = 5;
            this.label_NoeudFinal.Text = "Noeud final";
            this.label_NoeudFinal.Click += new System.EventHandler(this.label_NoeudFinal_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(336, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(479, 77);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            // 
            // button_init2
            // 
            this.button_init2.Location = new System.Drawing.Point(35, 67);
            this.button_init2.Name = "button_init2";
            this.button_init2.Size = new System.Drawing.Size(75, 23);
            this.button_init2.TabIndex = 8;
            this.button_init2.Text = "Init2";
            this.button_init2.UseVisualStyleBackColor = true;
            this.button_init2.Click += new System.EventHandler(this.button_init2_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(171, 93);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            this.listBoxgraphe.SelectedIndexChanged += new System.EventHandler(this.listBoxgraphe_SelectedIndexChanged);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 267);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.button_init2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_NoeudFinal);
            this.Controls.Add(this.label_NoeudInitial);
            this.Controls.Add(this.button_Dijkstra);
            this.Controls.Add(this.noeudFinal);
            this.Controls.Add(this.noeudInitial);
            this.Controls.Add(this.button_init1);
            this.Name = "Dijkstra";
            this.Text = "Form1";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button_init2;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}