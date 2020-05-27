using System;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class DashBoard : DevComponents.DotNetBar.OfficeForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddQuestions addQuestions = new AddQuestions();
            addQuestions.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTest addTest=new AddTest();
            addTest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCandidate addCandidate=new AddCandidate();
            addCandidate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewResult adminViewResult= new ViewResult();
            adminViewResult.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Login login=new Login();
            login.Show();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void AddSubject_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            AddTest addTest = new AddTest();
            addTest.Show();
        }

        private void AddCandidate_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            AddCandidate addCandidate = new AddCandidate();
            addCandidate.Show();
        }

        private void AddQuestions_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            AddQuestions addQuestions = new AddQuestions();
            addQuestions.Show();
        }

        private void ViewResults_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ViewResult adminViewResult = new ViewResult();
            adminViewResult.Show();
        }

        private void Logout_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }
    
    }
}
