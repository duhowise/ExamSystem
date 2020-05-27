using System;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class StartPage : DevComponents.DotNetBar.OfficeForm
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
        }
    }
}
