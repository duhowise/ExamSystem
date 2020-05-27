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
            this.UserInfromationGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfromationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfromationGrid
            // 
            this.UserInfromationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserInfromationGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.UserInfromationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfromationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInfromationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.UserInfromationGrid.Location = new System.Drawing.Point(0, 0);
            this.UserInfromationGrid.Name = "UserInfromationGrid";
            this.UserInfromationGrid.Size = new System.Drawing.Size(566, 286);
            this.UserInfromationGrid.TabIndex = 0;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 286);
            this.Controls.Add(this.UserInfromationGrid);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FlattenMDIBorder = false;
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserInfromationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserInfromationGrid;
    }
}