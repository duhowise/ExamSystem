using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSystem.UI
{
    public partial class TestPage : DevComponents.DotNetBar.OfficeForm
    {
        private readonly TestService _testService;
        private readonly ApplicationUserStateService _stateService;
        public TestPage(TestService testService,ApplicationUserStateService stateService)
        {
            InitializeComponent();
            _testService = testService;
            _stateService = stateService;
            this.FormClosing += TestPage_FormClosing; ;
        }

        private void TestPage_FormClosing(object sender, FormClosingEventArgs e)
        {
           var loginPage = Program.CreateServiceProvider().GetRequiredService<Login>();
            loginPage.Show();
        }

       
        public void GetTest()
        {
            if (TestCode.Text == "")
            {
                MessageBox.Show("Please Enter A Subject Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestCode.Focus();
                return;
            }
            try
            {
               var test= _testService.GetTestDetails(TestCode.Text);
                if (test!=null)
                {
                    _stateService.SetTestId(test.Id);
                    this.Hide();
                    var questionPage = Program.CreateServiceProvider().GetRequiredService<QuestionPage>();
                    questionPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Passcode", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetTest();
        }

        private void TestPage_Load(object sender, EventArgs e)
        {

        }
    }
  
}
