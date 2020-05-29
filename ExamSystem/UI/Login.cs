using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSystem.UI
{
    
    public partial class Login : DevComponents.DotNetBar.OfficeForm
    {
        private readonly LoginService _loginService;
        private readonly TestEvaluationService _testEvaluationService;
        private readonly ApplicationUserStateService _stateService;

        public Login(LoginService loginService, TestEvaluationService testEvaluationService, ApplicationUserStateService stateService)
        {
            InitializeComponent();
            _loginService = loginService;
            _testEvaluationService = testEvaluationService;
            _stateService = stateService;
        }

        //private static Login _instance;
        public static string UserPassword;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Enter))
            {
                ProcessLogin(UserPassword);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void ProcessLogin(string userPass)
        {
            
            
            try
            {
               
                    if (string.IsNullOrWhiteSpace(Usercode.Text))
                    {
                        MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usercode.Focus();
                        return;
                    }

                    var userLoginSuccessful = _loginService.Login(userPass, "user");
                    if (userLoginSuccessful==null)
                    {
                        MessageBox.Show(@"Wrong PassCode", @"information!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Usercode.Text = "";
                        Usercode.Focus();
                        return;
                    }
                    _stateService.SetCurrentlyLoggedInUser(userLoginSuccessful);
                    _testEvaluationService.UserInProgress(userLoginSuccessful);

                this.Hide();
                    var testPage = Program.CreateServiceProvider().GetRequiredService<TestPage>();
                testPage.Show();



            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserPassword = Usercode.Text.ToString();
            string status = _testEvaluationService.CheckUserStatus(UserPassword);
            if (status != "Completed")
            {
                ProcessLogin(UserPassword);
            }
            else
            {
                MessageBox.Show("You Have Already Taken The Test", "Caution",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Usercode.Text = "";
            }
            
          
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Codelabel_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
         var adminPage=   Program.CreateServiceProvider().GetRequiredService<Admin>();
            adminPage.Show();
        }
    }
}
