namespace ExamSystem.UI
{
    partial class UserPage
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
            this.UserInfromationGrid = new System.Windows.Forms.DataGridView();
            this.userInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfromationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfromationGrid
            // 
            this.UserInfromationGrid.AutoGenerateColumns = false;
            this.UserInfromationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserInfromationGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.UserInfromationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfromationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.UserInfromationGrid.DataSource = this.userInformationBindingSource;
            this.UserInfromationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInfromationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.UserInfromationGrid.Location = new System.Drawing.Point(0, 0);
            this.UserInfromationGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserInfromationGrid.Name = "UserInfromationGrid";
            this.UserInfromationGrid.RowHeadersWidth = 51;
            this.UserInfromationGrid.Size = new System.Drawing.Size(755, 352);
            this.UserInfromationGrid.TabIndex = 0;
            // 
            // userInformationBindingSource
            // 
            this.userInformationBindingSource.DataSource = typeof(ExamSystem.Data.UserInformation);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 352);
            this.Controls.Add(this.UserInfromationGrid);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FlattenMDIBorder = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserInfromationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserInfromationGrid;
        private System.Windows.Forms.BindingSource userInformationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}