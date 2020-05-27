namespace ExamSystem.UI
{
    partial class QuestionPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.Start = new Telerik.WinControls.UI.RadButton();
            this.OK = new Telerik.WinControls.UI.RadButton();
            this.secondLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.Hourlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.OptionC = new System.Windows.Forms.RadioButton();
            this.OptionA = new System.Windows.Forms.RadioButton();
            this.OptionB = new System.Windows.Forms.RadioButton();
            this.OptionD = new System.Windows.Forms.RadioButton();
            this.TestTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QuestionBox);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.secondLabel);
            this.panel1.Controls.Add(this.MinLabel);
            this.panel1.Controls.Add(this.Hourlabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.OptionC);
            this.panel1.Controls.Add(this.OptionA);
            this.panel1.Controls.Add(this.OptionB);
            this.panel1.Controls.Add(this.OptionD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel1.Size = new System.Drawing.Size(1350, 729);
            this.panel1.TabIndex = 0;
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.QuestionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(8, 52);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.Size = new System.Drawing.Size(1339, 310);
            this.QuestionBox.TabIndex = 51;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(1176, 687);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(74, 24);
            this.Start.TabIndex = 50;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click_2);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(1268, 687);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(74, 24);
            this.OK.TabIndex = 49;
            this.OK.Text = "OK >";
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // secondLabel
            // 
            this.secondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(1322, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(29, 20);
            this.secondLabel.TabIndex = 48;
            this.secondLabel.Text = "00";
            // 
            // MinLabel
            // 
            this.MinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(1274, 0);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(29, 20);
            this.MinLabel.TabIndex = 47;
            this.MinLabel.Text = "00";
            // 
            // Hourlabel
            // 
            this.Hourlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hourlabel.AutoSize = true;
            this.Hourlabel.Location = new System.Drawing.Point(1235, 0);
            this.Hourlabel.Name = "Hourlabel";
            this.Hourlabel.Size = new System.Drawing.Size(19, 20);
            this.Hourlabel.TabIndex = 46;
            this.Hourlabel.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1309, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1260, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = ":";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(8, 17);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(57, 20);
            this.Welcome.TabIndex = 43;
            this.Welcome.Text = "label2";
            // 
            // D
            // 
            this.D.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(20, 566);
            this.D.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(22, 20);
            this.D.TabIndex = 42;
            this.D.Text = "D";
            // 
            // C
            // 
            this.C.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(20, 530);
            this.C.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(21, 20);
            this.C.TabIndex = 41;
            this.C.Text = "C";
            // 
            // B
            // 
            this.B.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(20, 495);
            this.B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(21, 20);
            this.B.TabIndex = 40;
            this.B.Text = "B";
            // 
            // A
            // 
            this.A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(22, 459);
            this.A.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(21, 20);
            this.A.TabIndex = 39;
            this.A.Text = "A";
            // 
            // OptionC
            // 
            this.OptionC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OptionC.AutoSize = true;
            this.OptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionC.Location = new System.Drawing.Point(51, 530);
            this.OptionC.Margin = new System.Windows.Forms.Padding(5);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(14, 13);
            this.OptionC.TabIndex = 37;
            this.OptionC.TabStop = true;
            this.OptionC.UseVisualStyleBackColor = true;
            // 
            // OptionA
            // 
            this.OptionA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OptionA.AutoSize = true;
            this.OptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionA.Location = new System.Drawing.Point(51, 459);
            this.OptionA.Margin = new System.Windows.Forms.Padding(5);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(14, 13);
            this.OptionA.TabIndex = 35;
            this.OptionA.TabStop = true;
            this.OptionA.UseVisualStyleBackColor = true;
            // 
            // OptionB
            // 
            this.OptionB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OptionB.AutoSize = true;
            this.OptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionB.Location = new System.Drawing.Point(51, 495);
            this.OptionB.Margin = new System.Windows.Forms.Padding(5);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(14, 13);
            this.OptionB.TabIndex = 36;
            this.OptionB.TabStop = true;
            this.OptionB.UseVisualStyleBackColor = true;
            // 
            // OptionD
            // 
            this.OptionD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OptionD.AutoSize = true;
            this.OptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionD.Location = new System.Drawing.Point(51, 566);
            this.OptionD.Margin = new System.Windows.Forms.Padding(5);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(14, 13);
            this.OptionD.TabIndex = 38;
            this.OptionD.TabStop = true;
            this.OptionD.UseVisualStyleBackColor = true;
            // 
            // TestTime
            // 
            this.TestTime.Enabled = true;
            this.TestTime.Interval = 1000;
            this.TestTime.Tick += new System.EventHandler(this.TestTime_Tick_1);
            // 
            // QuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QuestionPage";
            this.Text = "QuestionPage";
            this.AutoSizeChanged += new System.EventHandler(this.QuestionPage_AutoSizeChanged);
            this.Load += new System.EventHandler(this.QuestionPage_Load);
            this.ClientSizeChanged += new System.EventHandler(this.QuestionPage_ClientSizeChanged);
            this.SizeChanged += new System.EventHandler(this.QuestionPage_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox QuestionBox;
        private Telerik.WinControls.UI.RadButton Start;
        private Telerik.WinControls.UI.RadButton OK;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label Hourlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.RadioButton OptionC;
        private System.Windows.Forms.RadioButton OptionA;
        private System.Windows.Forms.RadioButton OptionB;
        private System.Windows.Forms.RadioButton OptionD;
        private System.Windows.Forms.Timer TestTime;
    }
}