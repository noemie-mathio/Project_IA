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
            this.components = new System.ComponentModel.Container();
            this.dijkstraTextLabel = new System.Windows.Forms.Label();
            this.dijkstraTextBox = new System.Windows.Forms.TextBox();
            this.imageDijkstraOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.graphLabel = new System.Windows.Forms.Label();
            this.chargementGraphButton = new System.Windows.Forms.Button();
            this.envoyerButton = new System.Windows.Forms.Button();
            this.chargementImageOklabel = new System.Windows.Forms.Label();
            this.erreurLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Infobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dijkstraTextLabel
            // 
            this.dijkstraTextLabel.AutoSize = true;
            this.dijkstraTextLabel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dijkstraTextLabel.Location = new System.Drawing.Point(198, 62);
            this.dijkstraTextLabel.Name = "dijkstraTextLabel";
            this.dijkstraTextLabel.Size = new System.Drawing.Size(270, 15);
            this.dijkstraTextLabel.TabIndex = 0;
            this.dijkstraTextLabel.Text = "Ajouter les nouvelles données pour Dijkstra";
            // 
            // dijkstraTextBox
            // 
            this.dijkstraTextBox.Location = new System.Drawing.Point(261, 90);
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
            this.graphLabel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphLabel.Location = new System.Drawing.Point(227, 268);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(213, 15);
            this.graphLabel.TabIndex = 2;
            this.graphLabel.Text = "Ajoutez l\'image du graph associée";
            // 
            // chargementGraphButton
            // 
            this.chargementGraphButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargementGraphButton.Location = new System.Drawing.Point(248, 293);
            this.chargementGraphButton.Name = "chargementGraphButton";
            this.chargementGraphButton.Size = new System.Drawing.Size(169, 51);
            this.chargementGraphButton.TabIndex = 3;
            this.chargementGraphButton.Text = "Charger l\'image";
            this.chargementGraphButton.UseVisualStyleBackColor = true;
            this.chargementGraphButton.Click += new System.EventHandler(this.chargementGraphButton_Click);
            // 
            // envoyerButton
            // 
            this.envoyerButton.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envoyerButton.Location = new System.Drawing.Point(383, 379);
            this.envoyerButton.Name = "envoyerButton";
            this.envoyerButton.Size = new System.Drawing.Size(94, 41);
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
            // erreurLabel
            // 
            this.erreurLabel.AutoSize = true;
            this.erreurLabel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurLabel.ForeColor = System.Drawing.Color.Red;
            this.erreurLabel.Location = new System.Drawing.Point(111, 351);
            this.erreurLabel.Name = "erreurLabel";
            this.erreurLabel.Size = new System.Drawing.Size(450, 15);
            this.erreurLabel.TabIndex = 6;
            this.erreurLabel.Text = "Veuillez compléter la zone de texte ou charger une image représentative";
            // 
            // Infobutton
            // 
            this.Infobutton.BackColor = System.Drawing.Color.SkyBlue;
            this.Infobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobutton.Location = new System.Drawing.Point(426, 90);
            this.Infobutton.Name = "Infobutton";
            this.Infobutton.Size = new System.Drawing.Size(32, 23);
            this.Infobutton.TabIndex = 7;
            this.Infobutton.Text = "i";
            this.toolTip1.SetToolTip(this.Infobutton, "Entrez du contenue sous la forme :\r\n\r\nnombre de noeuds : 7\r\narc1 : 0 1 3\r\narc2 : " +
        "0 2 5\r\narc3 : 0 3 7\r\narc4 :1 4 8\r\narc5 : 2 4 3\r\narc6 : 4 5 7\r\narc7 : 5 6 4");
            this.Infobutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ajout d\'un nouveau Dijkstra";
            // 
            // NouveauDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Infobutton);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Infobutton;
        private System.Windows.Forms.Label label1;
    }
}