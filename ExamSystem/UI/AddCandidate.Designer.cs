using ExamSystem.Logic;

namespace ExamSystem.UI
{
    partial class AddCandidate
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
            this.button1 = new System.Windows.Forms.Button();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.userTest = new System.Windows.Forms.ComboBox();
            this.examDataSet = new ExamSystem.Logic.ExamDataSet();
            this.examDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(833, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserText
            // 
            this.UserText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserText.Location = new System.Drawing.Point(256, 53);
            this.UserText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserText.Multiline = true;
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(480, 36);
            this.UserText.TabIndex = 1;
            this.UserText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserText_KeyDown);
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(256, 122);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(480, 41);
            this.PasswordText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // UserType
            // 
            this.UserType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Slelect Type",
            "User",
            "Administrator"});
            this.UserType.Location = new System.Drawing.Point(256, 262);
            this.UserType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(480, 35);
            this.UserType.TabIndex = 11;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.UserType_SelectedIndexChanged);
            // 
            // userTest
            // 
            this.userTest.DataSource = this.testBindingSource;
            this.userTest.DisplayMember = "name";
            this.userTest.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTest.FormattingEnabled = true;
            this.userTest.Location = new System.Drawing.Point(256, 318);
            this.userTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTest.Name = "userTest";
            this.userTest.Size = new System.Drawing.Size(480, 39);
            this.userTest.TabIndex = 12;
            this.userTest.ValueMember = "Id";
            // 
            // examDataSet
            // 
            this.examDataSet.DataSetName = "ExamDataSet";
            this.examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examDataSetBindingSource
            // 
            this.examDataSetBindingSource.DataSource = this.examDataSet;
            this.examDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(256, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Generate Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(ExamSystem.Data.Test);
            // 
            // AddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userTest);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCandidate";
            this.Load += new System.EventHandler(this.AddCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.ComboBox userTest;
        private ExamSystem.Logic.ExamDataSet examDataSet;
        private System.Windows.Forms.BindingSource examDataSetBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource testBindingSource;
    }
}