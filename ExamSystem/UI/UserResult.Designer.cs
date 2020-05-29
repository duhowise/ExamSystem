namespace ExamSystem.UI
{
    partial class UserResult
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
            this.Score = new System.Windows.Forms.Label();
            this.closetime = new System.Windows.Forms.Timer(this.components);
            this.CorrectAnswer = new System.Windows.Forms.Label();
            this.WrongAnswer = new System.Windows.Forms.Label();
            this.UnAnswered = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Score.Font = new System.Drawing.Font("Arial Black", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Location = new System.Drawing.Point(0, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(1206, 668);
            this.Score.TabIndex = 0;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closetime
            // 
            this.closetime.Enabled = true;
            this.closetime.Interval = 1000;
            this.closetime.Tick += new System.EventHandler(this.closetime_Tick);
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CorrectAnswer.Location = new System.Drawing.Point(112, 536);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(182, 25);
            this.CorrectAnswer.TabIndex = 1;
            this.CorrectAnswer.Text = "Correct Answers :";
            // 
            // WrongAnswer
            // 
            this.WrongAnswer.AutoSize = true;
            this.WrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WrongAnswer.Location = new System.Drawing.Point(112, 590);
            this.WrongAnswer.Name = "WrongAnswer";
            this.WrongAnswer.Size = new System.Drawing.Size(175, 25);
            this.WrongAnswer.TabIndex = 2;
            this.WrongAnswer.Text = "Wrong Answers :";
            // 
            // UnAnswered
            // 
            this.UnAnswered.AutoSize = true;
            this.UnAnswered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnAnswered.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UnAnswered.Location = new System.Drawing.Point(112, 643);
            this.UnAnswered.Name = "UnAnswered";
            this.UnAnswered.Size = new System.Drawing.Size(247, 25);
            this.UnAnswered.TabIndex = 3;
            this.UnAnswered.Text = "Unanswered Questions :";
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Location = new System.Drawing.Point(391, 140);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(391, 108);
            this.Display.TabIndex = 4;
            this.Display.Text = "SCORE";
            // 
            // UserResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1206, 668);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.UnAnswered);
            this.Controls.Add(this.WrongAnswer);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.Score);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.MinimizeBox = false;
            this.Name = "UserResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer closetime;
        private System.Windows.Forms.Label CorrectAnswer;
        private System.Windows.Forms.Label WrongAnswer;
        private System.Windows.Forms.Label UnAnswered;
        private System.Windows.Forms.Label Display;
    }
}