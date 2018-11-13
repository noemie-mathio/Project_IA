namespace Project_IA
{
    partial class NouveauDijkstra
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
            this.dijkstraTextLabel = new System.Windows.Forms.Label();
            this.dijkstraTextBox = new System.Windows.Forms.TextBox();
            this.imageDijkstraOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.graphLabel = new System.Windows.Forms.Label();
            this.chargementGraphButton = new System.Windows.Forms.Button();
            this.envoyerButton = new System.Windows.Forms.Button();
            this.chargementImageOklabel = new System.Windows.Forms.Label();
            this.erreurLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dijkstraTextLabel
            // 
            this.dijkstraTextLabel.AutoSize = true;
            this.dijkstraTextLabel.Location = new System.Drawing.Point(83, 28);
            this.dijkstraTextLabel.Name = "dijkstraTextLabel";
            this.dijkstraTextLabel.Size = new System.Drawing.Size(210, 13);
            this.dijkstraTextLabel.TabIndex = 0;
            this.dijkstraTextLabel.Text = "Ajouter les nouvelles données pour Dijkstra";
            // 
            // dijkstraTextBox
            // 
            this.dijkstraTextBox.Location = new System.Drawing.Point(111, 53);
            this.dijkstraTextBox.Multiline = true;
            this.dijkstraTextBox.Name = "dijkstraTextBox";
            this.dijkstraTextBox.Size = new System.Drawing.Size(143, 160);
            this.dijkstraTextBox.TabIndex = 1;
            // 
            // imageDijkstraOpenFileDialog1
            // 
            this.imageDijkstraOpenFileDialog1.FileName = "openFileDialog1";
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(98, 230);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(167, 13);
            this.graphLabel.TabIndex = 2;
            this.graphLabel.Text = "Ajoutez l\'image du graph associée";
            // 
            // chargementGraphButton
            // 
            this.chargementGraphButton.Location = new System.Drawing.Point(101, 259);
            this.chargementGraphButton.Name = "chargementGraphButton";
            this.chargementGraphButton.Size = new System.Drawing.Size(164, 23);
            this.chargementGraphButton.TabIndex = 3;
            this.chargementGraphButton.Text = "Charger l\'image";
            this.chargementGraphButton.UseVisualStyleBackColor = true;
            this.chargementGraphButton.Click += new System.EventHandler(this.chargementGraphButton_Click);
            // 
            // envoyerButton
            // 
            this.envoyerButton.Location = new System.Drawing.Point(237, 318);
            this.envoyerButton.Name = "envoyerButton";
            this.envoyerButton.Size = new System.Drawing.Size(75, 32);
            this.envoyerButton.TabIndex = 4;
            this.envoyerButton.Text = "Envoyez";
            this.envoyerButton.UseVisualStyleBackColor = true;
            this.envoyerButton.Click += new System.EventHandler(this.envoyerButton_Click);
            // 
            // chargementImageOklabel
            // 
            this.chargementImageOklabel.AutoSize = true;
            this.chargementImageOklabel.Location = new System.Drawing.Point(111, 289);
            this.chargementImageOklabel.Name = "chargementImageOklabel";
            this.chargementImageOklabel.Size = new System.Drawing.Size(0, 13);
            this.chargementImageOklabel.TabIndex = 5;
            // 
            // label1
            // 
            this.erreurLabel.AutoSize = true;
            this.erreurLabel.Location = new System.Drawing.Point(86, 299);
            this.erreurLabel.Name = "erreurLabel";
            this.erreurLabel.Size = new System.Drawing.Size(35, 13);
            this.erreurLabel.TabIndex = 6;
            this.erreurLabel.Text = "Veuillez compléter la zone de texte ou charger une image représentative";
            // 
            // NouveauDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 382);
            this.Controls.Add(this.erreurLabel);
            this.Controls.Add(this.chargementImageOklabel);
            this.Controls.Add(this.envoyerButton);
            this.Controls.Add(this.chargementGraphButton);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.dijkstraTextBox);
            this.Controls.Add(this.dijkstraTextLabel);
            this.Name = "NouveauDijkstra";
            this.Text = "NouveauDijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dijkstraTextLabel;
        private System.Windows.Forms.TextBox dijkstraTextBox;
        private System.Windows.Forms.OpenFileDialog imageDijkstraOpenFileDialog1;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Button chargementGraphButton;
        private System.Windows.Forms.Button envoyerButton;
        private System.Windows.Forms.Label chargementImageOklabel;
        private System.Windows.Forms.Label erreurLabel;
    }
}