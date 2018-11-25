namespace Project_IA
{
    partial class Quizz
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(97, 93);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(281, 58);
            this.option1Button.TabIndex = 0;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(97, 178);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(281, 54);
            this.option2Button.TabIndex = 1;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(97, 260);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(281, 53);
            this.option3Button.TabIndex = 2;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option4Button
            // 
            this.option4Button.Location = new System.Drawing.Point(97, 337);
            this.option4Button.Name = "option4Button";
            this.option4Button.Size = new System.Drawing.Size(281, 53);
            this.option4Button.TabIndex = 3;
            this.option4Button.UseVisualStyleBackColor = true;
            this.option4Button.Click += new System.EventHandler(this.option4Button_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(33, 35);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(73, 17);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question :";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(341, 409);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(36, 409);
            this.labelScore.Name = "label1";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "";
            // 
            // Quizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 465);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.option4Button);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Name = "Quizz";
            this.Text = "Quizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button option4Button;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelScore;
    }
}