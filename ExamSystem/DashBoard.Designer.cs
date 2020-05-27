namespace ExamSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.AddSubject = new DevComponents.DotNetBar.BubbleButton();
            this.AddCandidate = new DevComponents.DotNetBar.BubbleButton();
            this.AddQuestions = new DevComponents.DotNetBar.BubbleButton();
            this.ViewResults = new DevComponents.DotNetBar.BubbleButton();
            this.UserInfo = new DevComponents.DotNetBar.BubbleButton();
            this.Logout = new DevComponents.DotNetBar.BubbleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.bubbleBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 703);
            this.panel1.TabIndex = 0;
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            // 
            // 
            // 
            this.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(140, 140);
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(80, 80);
            this.bubbleBar1.Location = new System.Drawing.Point(0, 580);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(1113, 123);
            this.bubbleBar1.TabIndex = 5;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.AddSubject,
            this.AddCandidate,
            this.AddQuestions,
            this.ViewResults,
            this.UserInfo,
            this.Logout});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "Dash Board";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // AddSubject
            // 
            this.AddSubject.Image = ((System.Drawing.Image)(resources.GetObject("AddSubject.Image")));
            this.AddSubject.ImageLarge = ((System.Drawing.Image)(resources.GetObject("AddSubject.ImageLarge")));
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.TooltipText = "Add Subject";
            this.AddSubject.Click += new DevComponents.DotNetBar.ClickEventHandler(this.AddSubject_Click);
            // 
            // AddCandidate
            // 
            this.AddCandidate.Image = ((System.Drawing.Image)(resources.GetObject("AddCandidate.Image")));
            this.AddCandidate.ImageLarge = ((System.Drawing.Image)(resources.GetObject("AddCandidate.ImageLarge")));
            this.AddCandidate.Name = "AddCandidate";
            this.AddCandidate.TooltipText = "Add Candidates";
            this.AddCandidate.Click += new DevComponents.DotNetBar.ClickEventHandler(this.AddCandidate_Click);
            // 
            // AddQuestions
            // 
            this.AddQuestions.Image = ((System.Drawing.Image)(resources.GetObject("AddQuestions.Image")));
            this.AddQuestions.ImageLarge = ((System.Drawing.Image)(resources.GetObject("AddQuestions.ImageLarge")));
            this.AddQuestions.Name = "AddQuestions";
            this.AddQuestions.TooltipText = "Add Questions";
            this.AddQuestions.Click += new DevComponents.DotNetBar.ClickEventHandler(this.AddQuestions_Click);
            // 
            // ViewResults
            // 
            this.ViewResults.Image = ((System.Drawing.Image)(resources.GetObject("ViewResults.Image")));
            this.ViewResults.ImageLarge = ((System.Drawing.Image)(resources.GetObject("ViewResults.ImageLarge")));
            this.ViewResults.Name = "ViewResults";
            this.ViewResults.TooltipText = "View Results";
            this.ViewResults.Click += new DevComponents.DotNetBar.ClickEventHandler(this.ViewResults_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.Image = ((System.Drawing.Image)(resources.GetObject("UserInfo.Image")));
            this.UserInfo.ImageLarge = ((System.Drawing.Image)(resources.GetObject("UserInfo.ImageLarge")));
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.TooltipText = "User Information";
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageLarge = ((System.Drawing.Image)(resources.GetObject("Logout.ImageLarge")));
            this.Logout.Name = "Logout";
            this.Logout.TooltipText = "Logout";
            this.Logout.Click += new DevComponents.DotNetBar.ClickEventHandler(this.Logout_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 703);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        private DevComponents.DotNetBar.BubbleButton AddSubject;
        private DevComponents.DotNetBar.BubbleButton AddCandidate;
        private DevComponents.DotNetBar.BubbleButton AddQuestions;
        private DevComponents.DotNetBar.BubbleButton ViewResults;
        private DevComponents.DotNetBar.BubbleButton UserInfo;
        private DevComponents.DotNetBar.BubbleButton Logout;
    }
}