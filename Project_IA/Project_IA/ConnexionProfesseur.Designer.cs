namespace Project_IA
{
    partial class ConnexionProfesseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pseudoLabel = new System.Windows.Forms.Label();
            this.pseudoTextBox = new System.Windows.Forms.TextBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.validerIdentifiantButton = new System.Windows.Forms.Button();
            this.msgErreurLabel = new System.Windows.Forms.Label();
            this.Retourbutton = new System.Windows.Forms.Button();
            this.Connexionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoLabel.Location = new System.Drawing.Point(319, 95);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(106, 22);
            this.pseudoLabel.TabIndex = 1;
            this.pseudoLabel.Text = "Identifiant";
            // 
            // pseudoTextBox
            // 
            this.pseudoTextBox.Location = new System.Drawing.Point(294, 129);
            this.pseudoTextBox.Name = "pseudoTextBox";
            this.pseudoTextBox.Size = new System.Drawing.Size(164, 20);
            this.pseudoTextBox.TabIndex = 3;
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLabel.Location = new System.Drawing.Point(305, 180);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(140, 22);
            this.mdpLabel.TabIndex = 4;
            this.mdpLabel.Text = "Mot de Passe";
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.Location = new System.Drawing.Point(294, 215);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(164, 20);
            this.mdpTextBox.TabIndex = 5;
            this.mdpTextBox.TextChanged += new System.EventHandler(this.mdpTextBox_TextChanged);
            // 
            // validerIdentifiantButton
            // 
            this.validerIdentifiantButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerIdentifiantButton.Location = new System.Drawing.Point(309, 300);
            this.validerIdentifiantButton.Name = "validerIdentifiantButton";
            this.validerIdentifiantButton.Size = new System.Drawing.Size(136, 49);
            this.validerIdentifiantButton.TabIndex = 6;
            this.validerIdentifiantButton.Text = "Se connecter";
            this.validerIdentifiantButton.UseVisualStyleBackColor = true;
            this.validerIdentifiantButton.Click += new System.EventHandler(this.validerIdentifiantButton_Click);
            // 
            // msgErreurLabel
            // 
            this.msgErreurLabel.AutoSize = true;
            this.msgErreurLabel.BackColor = System.Drawing.Color.Red;
            this.msgErreurLabel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErreurLabel.Location = new System.Drawing.Point(187, 261);
            this.msgErreurLabel.Name = "msgErreurLabel";
            this.msgErreurLabel.Size = new System.Drawing.Size(405, 15);
            this.msgErreurLabel.TabIndex = 7;
            this.msgErreurLabel.Text = "Votre identifiant ou mot de passe est incorrect ! Veuillez réessayer";
            // 
            // Retourbutton
            // 
            this.Retourbutton.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retourbutton.Location = new System.Drawing.Point(30, 34);
            this.Retourbutton.Name = "Retourbutton";
            this.Retourbutton.Size = new System.Drawing.Size(109, 39);
            this.Retourbutton.TabIndex = 8;
            this.Retourbutton.Text = "< Retour Menu";
            this.Retourbutton.UseVisualStyleBackColor = true;
            this.Retourbutton.Click += new System.EventHandler(this.Retourbutton_Click);
            // 
            // Connexionlabel
            // 
            this.Connexionlabel.AutoSize = true;
            this.Connexionlabel.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexionlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Connexionlabel.Location = new System.Drawing.Point(304, 34);
            this.Connexionlabel.Name = "Connexionlabel";
            this.Connexionlabel.Size = new System.Drawing.Size(140, 29);
            this.Connexionlabel.TabIndex = 9;
            this.Connexionlabel.Text = "Connexion";
            // 
            // ConnexionProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 449);
            this.Controls.Add(this.Connexionlabel);
            this.Controls.Add(this.Retourbutton);
            this.Controls.Add(this.msgErreurLabel);
            this.Controls.Add(this.validerIdentifiantButton);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.pseudoTextBox);
            this.Controls.Add(this.pseudoLabel);
            this.Name = "ConnexionProfesseur";
            this.Text = "ConnexionProfesseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button validerIdentifiantButton;
        private System.Windows.Forms.Label msgErreurLabel;
        private System.Windows.Forms.Button Retourbutton;
        private System.Windows.Forms.Label Connexionlabel;
    }
}