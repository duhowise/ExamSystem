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
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTTAKENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesTestsadnScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDataSet = new ExamDataSet();
            this.namesTestsadnScoresTableAdapter = new NamesTestsadnScoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Testscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
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
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn,
            this.tESTTAKENDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.Testscores.DataSource = this.namesTestsadnScoresBindingSource;
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
            this.Testscores.Name = "Testscores";
            this.Testscores.ReadOnly = true;
            this.Testscores.Size = new System.Drawing.Size(1207, 689);
            this.Testscores.TabIndex = 0;
            // 
            // nAMEOFSTUDENTDataGridViewTextBoxColumn
            // 
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn.DataPropertyName = "NAME OF STUDENT";
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn.HeaderText = "NAME OF STUDENT";
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn.Name = "nAMEOFSTUDENTDataGridViewTextBoxColumn";
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tESTTAKENDataGridViewTextBoxColumn
            // 
            this.tESTTAKENDataGridViewTextBoxColumn.DataPropertyName = "TEST TAKEN";
            this.tESTTAKENDataGridViewTextBoxColumn.HeaderText = "TEST TAKEN";
            this.tESTTAKENDataGridViewTextBoxColumn.Name = "tESTTAKENDataGridViewTextBoxColumn";
            this.tESTTAKENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "marks";
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            this.marksDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 689);
            this.Controls.Add(this.Testscores);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "ViewResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewResult";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Testscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX Testscores;
        private ExamDataSet examDataSet;
        private System.Windows.Forms.BindingSource namesTestsadnScoresBindingSource;
        private ExamSystem.Logic.ExamDataSetTableAdapters.NamesTestsadnScoresTableAdapter namesTestsadnScoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOFSTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTTAKENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
    }
}