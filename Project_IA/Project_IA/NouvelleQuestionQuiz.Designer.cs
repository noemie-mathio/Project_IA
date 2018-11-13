namespace Project_IA
{
    partial class NouvelleQuestionQuiz
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
            this.questionlabel = new System.Windows.Forms.Label();
            this.questiontextBox = new System.Windows.Forms.TextBox();
            this.reponse1label = new System.Windows.Forms.Label();
            this.reponse2label = new System.Windows.Forms.Label();
            this.reponse3label = new System.Windows.Forms.Label();
            this.reponse4label = new System.Windows.Forms.Label();
            this.reponse1textBox = new System.Windows.Forms.TextBox();
            this.reponse2textBox = new System.Windows.Forms.TextBox();
            this.reponse3textBox = new System.Windows.Forms.TextBox();
            this.reponse4textBox = new System.Windows.Forms.TextBox();
            this.bonnereponselabel = new System.Windows.Forms.Label();
            this.bonnereponsetextBox = new System.Windows.Forms.TextBox();
            this.explicationBonneReponselabel = new System.Windows.Forms.Label();
            this.explicationBonneReponsetextBox = new System.Windows.Forms.TextBox();
            this.envoyerbutton = new System.Windows.Forms.Button();
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
            this.mdpTextBox.Click += new System.EventHandler(this.mdpTextBox_TextChanged);
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
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.Location = new System.Drawing.Point(29, 55);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(55, 13);
            this.questionlabel.TabIndex = 7;
            this.questionlabel.Text = "Question :";
            // 
            // questiontextBox
            // 
            this.questiontextBox.Location = new System.Drawing.Point(103, 52);
            this.questiontextBox.Multiline = true;
            this.questiontextBox.Name = "questiontextBox";
            this.questiontextBox.Size = new System.Drawing.Size(261, 20);
            this.questiontextBox.TabIndex = 8;
            // 
            // reponse1label
            // 
            this.reponse1label.AutoSize = true;
            this.reponse1label.Location = new System.Drawing.Point(29, 91);
            this.reponse1label.Name = "reponse1label";
            this.reponse1label.Size = new System.Drawing.Size(74, 13);
            this.reponse1label.TabIndex = 9;
            this.reponse1label.Text = "Proposition 1 :";
            // 
            // reponse2label
            // 
            this.reponse2label.AutoSize = true;
            this.reponse2label.Location = new System.Drawing.Point(29, 134);
            this.reponse2label.Name = "reponse2label";
            this.reponse2label.Size = new System.Drawing.Size(74, 13);
            this.reponse2label.TabIndex = 10;
            this.reponse2label.Text = "Proposition 2 :";
            // 
            // reponse3label
            // 
            this.reponse3label.AutoSize = true;
            this.reponse3label.Location = new System.Drawing.Point(29, 177);
            this.reponse3label.Name = "reponse3label";
            this.reponse3label.Size = new System.Drawing.Size(74, 13);
            this.reponse3label.TabIndex = 11;
            this.reponse3label.Text = "Proposition 3 :";
            // 
            // reponse4label
            // 
            this.reponse4label.AutoSize = true;
            this.reponse4label.Location = new System.Drawing.Point(29, 221);
            this.reponse4label.Name = "reponse4label";
            this.reponse4label.Size = new System.Drawing.Size(74, 13);
            this.reponse4label.TabIndex = 12;
            this.reponse4label.Text = "Proposition 4 :";
            // 
            // reponse1textBox
            // 
            this.reponse1textBox.Location = new System.Drawing.Point(103, 88);
            this.reponse1textBox.Name = "reponse1textBox";
            this.reponse1textBox.Size = new System.Drawing.Size(261, 20);
            this.reponse1textBox.TabIndex = 13;
            // 
            // reponse2textBox
            // 
            this.reponse2textBox.Location = new System.Drawing.Point(103, 131);
            this.reponse2textBox.Name = "reponse2textBox";
            this.reponse2textBox.Size = new System.Drawing.Size(261, 20);
            this.reponse2textBox.TabIndex = 14;
            // 
            // reponse3textBox
            // 
            this.reponse3textBox.Location = new System.Drawing.Point(103, 177);
            this.reponse3textBox.Name = "reponse3textBox";
            this.reponse3textBox.Size = new System.Drawing.Size(261, 20);
            this.reponse3textBox.TabIndex = 15;
            // 
            // reponse4textBox
            // 
            this.reponse4textBox.Location = new System.Drawing.Point(103, 218);
            this.reponse4textBox.Name = "reponse4textBox";
            this.reponse4textBox.Size = new System.Drawing.Size(261, 20);
            this.reponse4textBox.TabIndex = 16;
            // 
            // bonnereponselabel
            // 
            this.bonnereponselabel.AutoSize = true;
            this.bonnereponselabel.Location = new System.Drawing.Point(32, 264);
            this.bonnereponselabel.Name = "bonnereponselabel";
            this.bonnereponselabel.Size = new System.Drawing.Size(192, 13);
            this.bonnereponselabel.TabIndex = 17;
            this.bonnereponselabel.Text = "Entrez le numéro de la bonne réponse :";
            // 
            // bonnereponsetextBox
            // 
            this.bonnereponsetextBox.Location = new System.Drawing.Point(230, 262);
            this.bonnereponsetextBox.Name = "bonnereponsetextBox";
            this.bonnereponsetextBox.Size = new System.Drawing.Size(39, 20);
            this.bonnereponsetextBox.TabIndex = 18;
            // 
            // explicationBonneReponselabel
            // 
            this.explicationBonneReponselabel.AutoSize = true;
            this.explicationBonneReponselabel.Location = new System.Drawing.Point(32, 295);
            this.explicationBonneReponselabel.Name = "explicationBonneReponselabel";
            this.explicationBonneReponselabel.Size = new System.Drawing.Size(138, 13);
            this.explicationBonneReponselabel.TabIndex = 19;
            this.explicationBonneReponselabel.Text = "Explication bonne réponse :";
            // 
            // explicationBonneReponsetextBox
            // 
            this.explicationBonneReponsetextBox.Location = new System.Drawing.Point(164, 295);
            this.explicationBonneReponsetextBox.Multiline = true;
            this.explicationBonneReponsetextBox.Name = "explicationBonneReponsetextBox";
            this.explicationBonneReponsetextBox.Size = new System.Drawing.Size(200, 20);
            this.explicationBonneReponsetextBox.TabIndex = 20;
            // 
            // envoyerbutton
            // 
            this.envoyerbutton.Location = new System.Drawing.Point(50, 332);
            this.envoyerbutton.Name = "envoyerbutton";
            this.envoyerbutton.Size = new System.Drawing.Size(75, 23);
            this.envoyerbutton.TabIndex = 21;
            this.envoyerbutton.Text = "Envoyer";
            this.envoyerbutton.UseVisualStyleBackColor = true;
            this.envoyerbutton.Click += new System.EventHandler(this.envoyerbutton_Click);
            // 
            // NouvelleQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 367);
            this.Controls.Add(this.envoyerbutton);
            this.Controls.Add(this.explicationBonneReponsetextBox);
            this.Controls.Add(this.explicationBonneReponselabel);
            this.Controls.Add(this.bonnereponsetextBox);
            this.Controls.Add(this.bonnereponselabel);
            this.Controls.Add(this.reponse4textBox);
            this.Controls.Add(this.reponse3textBox);
            this.Controls.Add(this.reponse2textBox);
            this.Controls.Add(this.reponse1textBox);
            this.Controls.Add(this.reponse4label);
            this.Controls.Add(this.reponse3label);
            this.Controls.Add(this.reponse2label);
            this.Controls.Add(this.reponse1label);
            this.Controls.Add(this.questiontextBox);
            this.Controls.Add(this.questionlabel);
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
        private System.Windows.Forms.Label questionlabel;
        private System.Windows.Forms.TextBox questiontextBox;
        private System.Windows.Forms.Label reponse1label;
        private System.Windows.Forms.Label reponse2label;
        private System.Windows.Forms.Label reponse3label;
        private System.Windows.Forms.Label reponse4label;
        private System.Windows.Forms.TextBox reponse1textBox;
        private System.Windows.Forms.TextBox reponse2textBox;
        private System.Windows.Forms.TextBox reponse3textBox;
        private System.Windows.Forms.TextBox reponse4textBox;
        private System.Windows.Forms.Label bonnereponselabel;
        private System.Windows.Forms.TextBox bonnereponsetextBox;
        private System.Windows.Forms.Label explicationBonneReponselabel;
        private System.Windows.Forms.TextBox explicationBonneReponsetextBox;
        private System.Windows.Forms.Button envoyerbutton;
    }
}