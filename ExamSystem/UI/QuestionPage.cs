using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Logic;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class QuestionPage : DevComponents.DotNetBar.OfficeForm
    {
        private readonly QuestionService _questionService;
        private readonly Yates _yates;

        public static int Count = 1;
        int _hour = 0, _minutes = 0, _seconds = 0;
        public Question _question;
        public Stack<Question> QuestionsStack { get; set; }

        public QuestionPage(QuestionService questionService, Yates yates)
        {
            InitializeComponent();
            _questionService = questionService;
            _yates = yates;
            QuestionsStack = new Stack<Question>();
            _question=new Question();
            SetSize();
            SetTexBoxSize();
        }

        public string testCode = null;
        private bool state = false;

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
                    questionid = questionId,
                    useranswer = answer,
                    userid = userId
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
                var loggedInUser = (CustomIdentity) Thread.CurrentPrincipal.Identity;
                InsertAnswer(SetAnswer(), _question.Id,loggedInUser.Credentials.Id);
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
                        //_userResultPage.Show();
                        Close();
                    }
                }
            }

            #endregion
        }

        private void GetQuestion()
        {
            if (QuestionsStack.Count == 0) return;
             _question = QuestionsStack.Pop();

            QuestionBox.Text = $@"{Count}. {_question.text}";
            OptionA.Text = _question.opA;
            OptionB.Text = _question.opB;
            OptionC.Text = _question.opC;
            OptionD.Text = _question.opd;
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
            var test = _questionService.GetTestDetails(testCode);
            if (test == null) return;
            Welcome.Text = $@"Welcome to the {test?.name} Examination!Press Start when Ready";
            var questions = test.Questions.ToList();
            QuestionsStack = _yates.ShuffleQuestions(questions);
            TestTime.Enabled = false;
            OK.Visible = false;
            Start.Visible = true;
            HideControls();
            OptionState();
        }
    }
}