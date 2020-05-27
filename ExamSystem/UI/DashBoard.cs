using System;
using DevComponents.DotNetBar;

namespace ExamSystem.UI
{
    public partial class DashBoard : OfficeForm
    {
   
        public DashBoard( )
        {
            InitializeComponent();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //_addQuestionsPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_addTestPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_addCandidatePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewResult adminViewResult= new ViewResult();
            adminViewResult.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Hide();
            //_loginPage.Show();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        private void UserInfo_Click(object sender, ClickEventArgs e)
        {
            //var userinfo=new UserPage();
            //userinfo.ShowDialog();
        }
        private void AddSubject_Click(object sender, ClickEventArgs e)
        {
            AddTest addTest = new AddTest();
            addTest.ShowDialog();
        }

        private void AddCandidate_Click(object sender, ClickEventArgs e)
        {
            AddCandidate addCandidate = new AddCandidate();
            addCandidate.ShowDialog();
        }

        private void AddQuestions_Click(object sender, ClickEventArgs e)
        {
            //_addQuestionsPage.ShowDialog();
        }

        private void ViewResults_Click(object sender, ClickEventArgs e)
        {
            //_viewResultPage.ShowDialog();
        }

        private void Logout_Click(object sender, ClickEventArgs e)
        {
           
            //Hide();
            //_loginPage.Show();
        }

 }
}
