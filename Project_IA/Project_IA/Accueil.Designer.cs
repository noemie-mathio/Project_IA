namespace Project_IA
{
    partial class Accueil
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
            this.dijkstraButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.ajoutQuizButton = new System.Windows.Forms.Button();
            this.ajoutDijkstraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.dijkstraButton.Location = new System.Drawing.Point(98, 90);
            this.dijkstraButton.Name = "button1";
            this.dijkstraButton.Size = new System.Drawing.Size(140, 54);
            this.dijkstraButton.TabIndex = 0;
            this.dijkstraButton.Text = "Dijkstra";
            this.dijkstraButton.UseVisualStyleBackColor = true;
            this.dijkstraButton.Click += new System.EventHandler(this.dijkstraButton_Click);
            // 
            // button2
            // 
            this.quizButton.Location = new System.Drawing.Point(98, 160);
            this.quizButton.Name = "button2";
            this.quizButton.Size = new System.Drawing.Size(140, 53);
            this.quizButton.TabIndex = 1;
            this.quizButton.Text = "Test QCM";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // button3
            // 
            this.ajoutQuizButton.Location = new System.Drawing.Point(244, 178);
            this.ajoutQuizButton.Name = "button3";
            this.ajoutQuizButton.Size = new System.Drawing.Size(39, 35);
            this.ajoutQuizButton.TabIndex = 2;
            this.ajoutQuizButton.Text = "+";
            this.ajoutQuizButton.UseVisualStyleBackColor = true;
            this.ajoutQuizButton.Click += new System.EventHandler(this.ajoutQuizButton_Click);
            // 
            // button4
            // 
            this.ajoutDijkstraButton.Location = new System.Drawing.Point(244, 109);
            this.ajoutDijkstraButton.Name = "button4";
            this.ajoutDijkstraButton.Size = new System.Drawing.Size(39, 35);
            this.ajoutDijkstraButton.TabIndex = 3;
            this.ajoutDijkstraButton.Text = "+";
            this.ajoutDijkstraButton.UseVisualStyleBackColor = true;
            this.ajoutDijkstraButton.Click += new System.EventHandler(this.ajoutDijkstraButton_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 329);
            this.Controls.Add(this.ajoutDijkstraButton);
            this.Controls.Add(this.ajoutQuizButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.dijkstraButton);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dijkstraButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button ajoutQuizButton;
        private System.Windows.Forms.Button ajoutDijkstraButton;
    }
}

