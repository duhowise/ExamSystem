using ExamSystem.Logic;
using ExamSystem.Logic.ExamDataSetTableAdapters;

namespace ExamSystem.UI
{
    using  System.Data;
    partial class ViewResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Testscores = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.namesTestsadnScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDataSet = new ExamSystem.Logic.ExamDataSet();
            this.namesTestsadnScoresTableAdapter = new ExamSystem.Logic.ExamDataSetTableAdapters.NamesTestsadnScoresTableAdapter();
            this.namesTestsadnScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Testscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Testscores
            // 
            this.Testscores.AllowUserToAddRows = false;
            this.Testscores.AllowUserToDeleteRows = false;
            this.Testscores.AllowUserToOrderColumns = true;
            this.Testscores.AutoGenerateColumns = false;
            this.Testscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Testscores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Testscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Testscores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfStudentDataGridViewTextBoxColumn,
            this.testTakenDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.Testscores.DataSource = this.namesTestsadnScoreBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Testscores.DefaultCellStyle = dataGridViewCellStyle1;
            this.Testscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Testscores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Testscores.Location = new System.Drawing.Point(0, 0);
            this.Testscores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Testscores.Name = "Testscores";
            this.Testscores.ReadOnly = true;
            this.Testscores.RowHeadersWidth = 51;
            this.Testscores.Size = new System.Drawing.Size(1609, 848);
            this.Testscores.TabIndex = 0;
            // 
            // namesTestsadnScoresBindingSource
            // 
            this.namesTestsadnScoresBindingSource.DataMember = "NamesTestsadnScores";
            this.namesTestsadnScoresBindingSource.DataSource = this.examDataSet;
            // 
            // examDataSet
            // 
            this.examDataSet.DataSetName = "ExamDataSet";
            this.examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namesTestsadnScoresTableAdapter
            // 
            this.namesTestsadnScoresTableAdapter.ClearBeforeFill = true;
            // 
            // namesTestsadnScoreBindingSource
            // 
            this.namesTestsadnScoreBindingSource.DataSource = typeof(ExamSystem.Data.NamesTestsadnScore);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameOfStudentDataGridViewTextBoxColumn
            // 
            this.nameOfStudentDataGridViewTextBoxColumn.DataPropertyName = "NameOfStudent";
            this.nameOfStudentDataGridViewTextBoxColumn.HeaderText = "NameOfStudent";
            this.nameOfStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameOfStudentDataGridViewTextBoxColumn.Name = "nameOfStudentDataGridViewTextBoxColumn";
            this.nameOfStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testTakenDataGridViewTextBoxColumn
            // 
            this.testTakenDataGridViewTextBoxColumn.DataPropertyName = "TestTaken";
            this.testTakenDataGridViewTextBoxColumn.HeaderText = "TestTaken";
            this.testTakenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testTakenDataGridViewTextBoxColumn.Name = "testTakenDataGridViewTextBoxColumn";
            this.testTakenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "Marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "Marks";
            this.marksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            this.marksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 848);
            this.Controls.Add(this.Testscores);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewResult";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Testscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX Testscores;
        private ExamDataSet examDataSet;
        private System.Windows.Forms.BindingSource namesTestsadnScoresBindingSource;
        private ExamSystem.Logic.ExamDataSetTableAdapters.NamesTestsadnScoresTableAdapter namesTestsadnScoresTableAdapter;
        private System.Windows.Forms.BindingSource namesTestsadnScoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
    }
}