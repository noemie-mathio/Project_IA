namespace Project_IA
{
    partial class NouvelleQuestion
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
            this.mdpLabel = new System.Windows.Forms.Label();
            this.pseudoTextBox = new System.Windows.Forms.TextBox();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.validerIdentifiantButton = new System.Windows.Forms.Button();
            this.msgErreurLabel = new System.Windows.Forms.Label();
            this.titreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Location = new System.Drawing.Point(72, 55);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(53, 13);
            this.pseudoLabel.TabIndex = 0;
            this.pseudoLabel.Text = "Identifiant";
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Location = new System.Drawing.Point(72, 134);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(72, 13);
            this.mdpLabel.TabIndex = 1;
            this.mdpLabel.Text = "Mot de Passe";
            // 
            // pseudoTextBox
            // 
            this.pseudoTextBox.Location = new System.Drawing.Point(75, 84);
            this.pseudoTextBox.Name = "pseudoTextBox";
            this.pseudoTextBox.Size = new System.Drawing.Size(164, 20);
            this.pseudoTextBox.TabIndex = 2;
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.Location = new System.Drawing.Point(75, 177);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(164, 20);
            this.mdpTextBox.TabIndex = 3;
            // 
            // validerIdentifiantButton
            // 
            this.validerIdentifiantButton.Location = new System.Drawing.Point(164, 221);
            this.validerIdentifiantButton.Name = "validerIdentifiantButton";
            this.validerIdentifiantButton.Size = new System.Drawing.Size(75, 23);
            this.validerIdentifiantButton.TabIndex = 4;
            this.validerIdentifiantButton.Text = "Envoyer";
            this.validerIdentifiantButton.UseVisualStyleBackColor = true;
            this.validerIdentifiantButton.Click += new System.EventHandler(this.validerIdentifiantButton_Click);
            // 
            // msgErreurLabel
            // 
            this.msgErreurLabel.AutoSize = true;
            this.msgErreurLabel.BackColor = System.Drawing.Color.Red;
            this.msgErreurLabel.Location = new System.Drawing.Point(29, 265);
            this.msgErreurLabel.Name = "msgErreurLabel";
            this.msgErreurLabel.Size = new System.Drawing.Size(315, 13);
            this.msgErreurLabel.TabIndex = 5;
            this.msgErreurLabel.Text = "Votre identifiant ou mot de passe est incorrect ! Veuillez réessayer";
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Location = new System.Drawing.Point(89, 13);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(147, 13);
            this.titreLabel.TabIndex = 6;
            this.titreLabel.Text = "Ajouter une nouvelle question";
            // 
            // NouvelleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 350);
            this.Controls.Add(this.titreLabel);
            this.Controls.Add(this.msgErreurLabel);
            this.Controls.Add(this.validerIdentifiantButton);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.pseudoTextBox);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.pseudoLabel);
            this.Name = "NouvelleQuestion";
            this.Text = "NouvelleQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button validerIdentifiantButton;
        private System.Windows.Forms.Label msgErreurLabel;
        private System.Windows.Forms.Label titreLabel;
    }
}