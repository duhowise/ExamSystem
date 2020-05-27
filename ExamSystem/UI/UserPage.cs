using System;
using ExamSystem.Logic;
using ExamSystem.Services;


namespace ExamSystem.UI
{
    public partial class UserPage : DevComponents.DotNetBar.OfficeForm
    {
        private readonly UserInformationService _userInformationService;

        public UserPage(UserInformationService userInformationService)
        {
            _userInformationService = userInformationService;
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            UserInfromationGrid.DataSource = _userInformationService.GetUserData();
        }
    }
}
