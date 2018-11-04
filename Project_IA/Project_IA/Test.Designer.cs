namespace Project_IA
{
    partial class Test
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
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option4Button = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(49, 55);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(263, 72);
            this.option1Button.TabIndex = 0;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(49, 142);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(263, 72);
            this.option2Button.TabIndex = 0;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(49, 238);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(263, 77);
            this.option3Button.TabIndex = 2;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option4Button
            // 
            this.option4Button.Location = new System.Drawing.Point(49, 336);
            this.option4Button.Name = "option4Button";
            this.option4Button.Size = new System.Drawing.Size(263, 70);
            this.option4Button.TabIndex = 3;
            this.option4Button.UseVisualStyleBackColor = true;
            this.option4Button.Click += new System.EventHandler(this.option4Button_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(356, 55);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 4;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 499);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.option4Button);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button option4Button;
        private System.Windows.Forms.Label scoreLabel;
    }
}