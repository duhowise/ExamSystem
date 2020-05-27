namespace ExamSystem
{
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
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTTAKENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesTestsadnScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDataSet = new ExamSystem.ExamDataSet();
            this.namesTestsadnScoresTableAdapter = new ExamSystem.ExamDataSetTableAdapters.NamesTestsadnScoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToOrderColumns = true;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEOFSTUDENTDataGridViewTextBoxColumn,
            this.tESTTAKENDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.namesTestsadnScoresBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.Size = new System.Drawing.Size(1207, 689);
            this.dataGridViewX1.TabIndex = 0;
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
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "ViewResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewResult";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTestsadnScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private ExamDataSet examDataSet;
        private System.Windows.Forms.BindingSource namesTestsadnScoresBindingSource;
        private ExamDataSetTableAdapters.NamesTestsadnScoresTableAdapter namesTestsadnScoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOFSTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTTAKENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
    }
}