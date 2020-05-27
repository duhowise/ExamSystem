using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class Admin : DevComponents.DotNetBar.OfficeForm
    {
        private readonly Login _loginPage;
        private LoginService _loginService;


        public Admin( LoginService loginService, Login loginPage)
        {
            InitializeComponent();
            _loginService = loginService;
            _loginPage = loginPage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminCode.Text))
            {
                MessageBox.Show(@"Please enter administrator password", @"information!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            try
            {
                var userSuccessfullyLoggedIn = _loginService.Login(AdminCode.Text, "Administrator");

                if (userSuccessfullyLoggedIn!=null)
                {
                    this.Hide();
                    //_dashBoardPage.Show();
                }
                else
                {
                    
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Hide();
            _loginPage.ShowDialog();
        }
    }
}
