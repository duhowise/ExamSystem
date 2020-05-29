using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Logic;
using ExamSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using Telerik.WinControls;

namespace ExamSystem.UI
{
    public partial class QuestionPage : DevComponents.DotNetBar.OfficeForm
    {
        private readonly QuestionService _questionService;
        private readonly Yates _yates;
        private readonly ApplicationUserStateService _stateService;
        private readonly TestService _testService;
        public static int Count = 1;
        int _hour = 0, _minutes = 0, _seconds = 0;
        public Question Question;
        public Stack<Question> QuestionsStack { get; set; }

        public QuestionPage(QuestionService questionService, Yates yates,ApplicationUserStateService stateService,TestService testService)
        {
            InitializeComponent();
            this.Load += QuestionPage_Load;
            _questionService = questionService;
            _yates = yates;
            _stateService = stateService;
            _testService = testService;
            QuestionsStack = new Stack<Question>();
            Question=new Question();
            SetSize();
            SetTexBoxSize();
        }

       


        private void SetSize()
        {
            //makes question page responsive to fit any screen size
            //text on screen re adjusts to meet screen size
            System.Drawing.Rectangle formSize = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(formSize.Width - 2, formSize.Height - 2);
            this.Location = new System.Drawing.Point(5, 5);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetTexBoxSize()
        {
            //makes textbox wich contains question text responsive
            QuestionBox.Width = this.Width - 4;
            QuestionBox.Margin = new Padding(5);
        }

        public string SetAnswer()
        {
            string answer = null;
            if (OptionA.Checked)
            {
                answer = "A";
            }
            else if (OptionB.Checked)
            {
                answer = "B";
            }
            else if (OptionC.Checked)
            {
                answer = "C";
            }
            else if (OptionD.Checked)
            {
                answer = "D";
            }
            else
            {
                MessageBox.Show(@"You have to choose an Answer", @"sorry");
            }

            return answer;
        }

        public void OptionState()
        {
            OptionA.Checked = false;
            OptionB.Checked = false;
            OptionC.Checked = false;
            OptionD.Checked = false;
        }

        public void InsertAnswer(string answer, int questionId, int userId)
        {
            try
            {
               
                _questionService.InsertQuestionAnswer(new AnsweredQuestion
                {
                    Questionid = questionId,
                    Useranswer = answer,
                    Userid = userId
                });
                Count++;

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void HideControls()
        {
            A.Visible = false;
            B.Visible = false;
            C.Visible = false;
            D.Visible = false;
            OptionA.Visible = false;
            OptionB.Visible = false;
            OptionC.Visible = false;
            OptionD.Visible = false;
            QuestionBox.Visible = false;
        }

        private void QuestionPage_ClientSizeChanged(object sender, EventArgs e)
        {
            SetTexBoxSize();
        }

        private void QuestionPage_AutoSizeChanged(object sender, EventArgs e)
        {
            SetTexBoxSize();
        }

        private void QuestionPage_SizeChanged(object sender, EventArgs e)
        {
            SetTexBoxSize();
        }

        //private void Start_Click_1(object sender, EventArgs e)
        //{
        //    TestTime.Enabled = true;
        //    Start.Visible = false;
        //    Welcome.Visible = false;
        //    GetQuestion();
        //    OK.Visible = true;
        //    ShowControls();
        //    OptionState();
        //}

        private void TestTime_Tick_1(object sender, EventArgs e)
        {
            _seconds = _seconds - 1;
            string s = Convert.ToString(_seconds);
            secondLabel.Text = s;
            string h = Convert.ToString(_hour);
            Hourlabel.Text = h;
            string m = Convert.ToString(_minutes);
            MinLabel.Text = m;
            if (_seconds == -1)
            {
                _minutes = _minutes - 1;
                _seconds = 59;
            }

            if (_minutes == -1)
            {
                _hour = _hour - 1;
                _minutes = 59;
            }

            switch (_hour)
            {
                case 0 when _minutes == 0 && _seconds == 0:
                {
                    TestTime.Stop();
                    var done = MessageBox.Show("Please your time is up click ok to display your Results",
                        "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (done == DialogResult.OK)
                    {
                        Hide();
                        //_userResultPage.Show();
                    }

                    break;
                }
            }
        }

        private void Start_Click_2(object sender, EventArgs e)
        {
            TestTime.Enabled = true;
            TestTime.Start();
            Start.Visible = false;
            Welcome.Visible = false;
            GetQuestion();
           
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            #region

            if (SetAnswer() != null)
            {
                var sure = MessageBox.Show("Are You Sure " + SetAnswer() + " is the Answer ?", "Confirm",
                    MessageBoxButtons.YesNo);
                if (sure != DialogResult.Yes) return;
              
                InsertAnswer(SetAnswer(), Question.Id,_stateService.CurrentlyLoggedInUser().Id);
                if (QuestionsStack.Count() != 0)
                {
                    GetQuestion();
                    OptionState();
                }
                else
                {
                    var complete = MessageBox.Show("You Have Successfully Completed the Test", "Confirm",
                        MessageBoxButtons.OK);
                    if (complete == DialogResult.OK)
                    {
                        var userResult = Program.CreateServiceProvider().GetRequiredService<UserResult>();
                        userResult.ShowDialog();
                        Close();
                    }
                }
            }

            #endregion
        }

        private void GetQuestion()
        {
            if (QuestionsStack.Count == 0) return;
             Question = QuestionsStack.Pop();

            QuestionBox.Text = $@"{Count}. {Question.Text}";
            OptionA.Text = Question.OpA;
            OptionB.Text = Question.OpB;
            OptionC.Text = Question.OpC;
            OptionD.Text = Question.Opd;
            OK.Visible = true;
            ShowControls();
            OptionState();
        }

        public void ShowControls()
        {
            A.Visible = true;
            B.Visible = true;
            C.Visible = true;
            D.Visible = true;
            OptionA.Visible = true;
            OptionB.Visible = true;
            OptionC.Visible = true;
            OptionD.Visible = true;
            QuestionBox.Visible = true;
        }


        private void QuestionPage_Load(object sender, EventArgs e)
        {
            var test = _testService.GetTestDetails(_stateService.GetTestId());
            if (test != null)
            {
                Welcome.Text = $@"Welcome to the {test?.Name} Examination!Press Start when Ready";
                var questions = test.Questions.ToList();
                QuestionsStack = _yates.ShuffleQuestions(questions);
                TestTime.Enabled = false;
                OK.Visible = false;
                Start.Visible = true;
                HideControls();
                OptionState();
            }else{
                MessageBox.Show("No Test found for the provided code");

            }

        }
    }
}