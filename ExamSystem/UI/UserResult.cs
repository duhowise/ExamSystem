using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class UserResult : DevComponents.DotNetBar.OfficeForm
    {
        private readonly TestEvaluationService _testEvaluationService;
        private readonly TestService _testService;
        private readonly User _currentUser;

        public UserResult(TestEvaluationService testEvaluationService,ApplicationUserStateService applicationUserStateService,TestService testService)
        {
            InitializeComponent();

            _testEvaluationService = testEvaluationService;
            _testService = testService;
            _currentUser = applicationUserStateService.CurrentlyLoggedInUser();
            TestId = applicationUserStateService.GetTestId();
            this.Load += UserResult_Load;
            
        }


        private decimal _score;

        public int TestId;
        private int _time = 0;
        private int _correct = 0;
        int _wrong = 0;
        private int _nonAnswered = 0;
        
        public int GetMarksObtainedByUser()
        {
            return _testEvaluationService.GetTotalMarksForUser(_currentUser.Id, TestId);
        }


        public void CloseTimer()
        {
            if (_time != 60) return;
            closetime.Stop();
            Hide();
            Application.Exit();
            Application.Restart();
        }

      


        private void UserResult_Load(object sender, EventArgs e)
        {

            closetime.Start();
            int mark = GetMarksObtainedByUser();

            var test = _testService.GetTestDetails(TestId);
            _wrong = _testEvaluationService.GetAllWrongAnswersForUser(_currentUser.Id, TestId);
            _correct = _testEvaluationService.GetAllCorrectAnswersForUser(TestId, _currentUser.Id);
            _score = decimal.Round(mark);
            CorrectAnswer.Text += $@" {_correct}";
            WrongAnswer.Text += $@"{_wrong}";

            int total = _testEvaluationService.GetTotalMarksAssignedToTest(TestId);
            _nonAnswered = Convert.ToInt32(test.NumberofQ) - (_correct + _wrong);
            UnAnswered.Text += $@" {_nonAnswered}";

            Score.Text = Convert.ToString(_score, CultureInfo.InvariantCulture);
            if (_score >= 25)
            {
                Score.ForeColor = Color.Green;
                Display.ForeColor = Color.Green;
            }

            if (_score < 25 && _score > 15)
            {
                Score.ForeColor = Color.Yellow;
                Display.ForeColor = Color.Yellow;
            }

            if (_score < 15)
            {
                Score.ForeColor = Color.Red;
                Display.ForeColor = Color.Red;
            }

            _testEvaluationService.SaveMarks(_score, TestId, _currentUser.Id);
            _testEvaluationService.SaveUserStatus(_currentUser);
        }

        private void closetime_Tick(object sender, EventArgs e)
        {
            _time++;
            CloseTimer();
        }
    }
}