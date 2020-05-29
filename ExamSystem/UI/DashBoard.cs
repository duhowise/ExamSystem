using System;
using DevComponents.DotNetBar;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSystem.UI
{
    public partial class DashBoard : OfficeForm
    {
        


        public DashBoard( )
        {
            InitializeComponent();

        }

        

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        private void UserInfo_Click(object sender, ClickEventArgs e)
        {
            var userPage = Program.CreateServiceProvider().GetRequiredService<UserPage>();
            userPage.ShowDialog();
        }
        private void AddSubject_Click(object sender, ClickEventArgs e)
        {
            var addTest = Program.CreateServiceProvider().GetRequiredService<AddTest>(); 
            addTest.ShowDialog();
        }

        private void AddCandidate_Click(object sender, ClickEventArgs e)
        {
           var  addCandidate = Program.CreateServiceProvider().GetRequiredService<AddCandidate>();
            addCandidate.ShowDialog();
        }

        private void AddQuestions_Click(object sender, ClickEventArgs e)
        {
            var addQuestions = Program.CreateServiceProvider().GetRequiredService<AddQuestions>();
            addQuestions.ShowDialog();
        }

        private void ViewResults_Click(object sender, ClickEventArgs e)
        {
            var viewResult = Program.CreateServiceProvider().GetRequiredService<ViewResult>();
            viewResult.ShowDialog();
        }

        private void Logout_Click(object sender, ClickEventArgs e)
        {

            Hide();
           var loginPage = Program.CreateServiceProvider().GetRequiredService<Login>();
           loginPage.ShowDialog();
        }

    }
}
