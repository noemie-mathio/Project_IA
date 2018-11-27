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
            this.Connexionbutton = new System.Windows.Forms.Button();
            this.TitreAccueilLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dijkstraButton
            // 
            this.dijkstraButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dijkstraButton.Location = new System.Drawing.Point(198, 107);
            this.dijkstraButton.Name = "dijkstraButton";
            this.dijkstraButton.Size = new System.Drawing.Size(341, 84);
            this.dijkstraButton.TabIndex = 0;
            this.dijkstraButton.Text = "Exercice Algorithme de Dijkstra";
            this.dijkstraButton.UseVisualStyleBackColor = true;
            this.dijkstraButton.Click += new System.EventHandler(this.dijkstraButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizButton.Location = new System.Drawing.Point(198, 263);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(341, 83);
            this.quizButton.TabIndex = 1;
            this.quizButton.Text = "QCM sur l\'IA";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // ajoutQuizButton
            // 
            this.ajoutQuizButton.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutQuizButton.Location = new System.Drawing.Point(257, 352);
            this.ajoutQuizButton.Name = "ajoutQuizButton";
            this.ajoutQuizButton.Size = new System.Drawing.Size(218, 53);
            this.ajoutQuizButton.TabIndex = 2;
            this.ajoutQuizButton.Text = "Ajouter une question";
            this.ajoutQuizButton.UseVisualStyleBackColor = true;
            this.ajoutQuizButton.Click += new System.EventHandler(this.ajoutQuizButton_Click);
            // 
            // ajoutDijkstraButton
            // 
            this.ajoutDijkstraButton.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutDijkstraButton.Location = new System.Drawing.Point(265, 192);
            this.ajoutDijkstraButton.Name = "ajoutDijkstraButton";
            this.ajoutDijkstraButton.Size = new System.Drawing.Size(210, 53);
            this.ajoutDijkstraButton.TabIndex = 3;
            this.ajoutDijkstraButton.Text = "Ajouter un Dijkstra";
            this.ajoutDijkstraButton.UseVisualStyleBackColor = true;
            this.ajoutDijkstraButton.Click += new System.EventHandler(this.ajoutDijkstraButton_Click);
            // 
            // Connexionbutton
            // 
            this.Connexionbutton.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexionbutton.Location = new System.Drawing.Point(604, 15);
            this.Connexionbutton.Name = "Connexionbutton";
            this.Connexionbutton.Size = new System.Drawing.Size(110, 50);
            this.Connexionbutton.TabIndex = 4;
            this.Connexionbutton.Text = "Connexion";
            this.Connexionbutton.UseVisualStyleBackColor = true;
            this.Connexionbutton.Click += new System.EventHandler(this.Connexionbutton_Click);
            // 
            // TitreAccueilLabel
            // 
            this.TitreAccueilLabel.AutoSize = true;
            this.TitreAccueilLabel.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAccueilLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TitreAccueilLabel.Location = new System.Drawing.Point(202, 24);
            this.TitreAccueilLabel.Name = "TitreAccueilLabel";
            this.TitreAccueilLabel.Size = new System.Drawing.Size(337, 25);
            this.TitreAccueilLabel.TabIndex = 5;
            this.TitreAccueilLabel.Text = "Révision module IA semestre 7";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 466);
            this.Controls.Add(this.TitreAccueilLabel);
            this.Controls.Add(this.Connexionbutton);
            this.Controls.Add(this.ajoutDijkstraButton);
            this.Controls.Add(this.ajoutQuizButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.dijkstraButton);
            this.Name = "Accueil";
            this.Text = "IA";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dijkstraButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button ajoutQuizButton;
        private System.Windows.Forms.Button ajoutDijkstraButton;
        private System.Windows.Forms.Button Connexionbutton;
        private System.Windows.Forms.Label TitreAccueilLabel;
    }
}

