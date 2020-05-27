using System;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Logic;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    
    public partial class Login : DevComponents.DotNetBar.OfficeForm
    {
        private readonly LoginService _loginService;
        private readonly IPageService<Admin> _adminPageService;

        public Login(LoginService loginService,IPageService<Admin> adminPageService)
        {
            InitializeComponent();
            _loginService = loginService;
            _adminPageService = adminPageService;
        }

        //private static Login _instance;
        public static string pass;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Enter))
            {
                ProcessLogin(pass);
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
                    AppDomain.CurrentDomain.SetThreadPrincipal(new ClaimsPrincipal(new CustomIdentity(userLoginSuccessful, new[] { userLoginSuccessful.UserType })));
                    this.Hide();
                    //_testPage.Show();

               

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pass = Usercode.Text.ToString();
            string status = new TestEvaluationService().CheckUserStatus(pass);
            if (status != "Completed")
            {
                ProcessLogin(pass);
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
            _adminPageService.GetPage().Show();
        }
    }
}
