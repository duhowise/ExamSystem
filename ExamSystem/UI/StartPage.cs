using System;

namespace ExamSystem.UI
{
    public partial class StartPage : DevComponents.DotNetBar.OfficeForm
    {
        private readonly Login _loginPage;

        public StartPage(Login loginPage)
        {
            _loginPage = loginPage;
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            _loginPage.Show();
        }
    }
}
