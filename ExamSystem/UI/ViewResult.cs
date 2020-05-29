using System;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class ViewResult : DevComponents.DotNetBar.OfficeForm
    {
        private readonly UserInformationService _userInformationService;

        public ViewResult(UserInformationService userInformationService)
        {
            _userInformationService = userInformationService;
            InitializeComponent();
        }

        private void ViewResult_Load(object sender, EventArgs e)
        {
            Testscores.DataSource = _userInformationService.GetUserNamesAndTestScores();

        }
    }
}
