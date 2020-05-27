using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class UserResult : DevComponents.DotNetBar.OfficeForm
    {
        public static string userCode;

        private decimal score;

        public string testCode;
        private  int time = 0;
        private int Correct = 0;
        int Wrong=0;
        private int nonAnswered = 0;

        public UserResult()
        {
            InitializeComponent();
        }

        public int GetMarks()
        {
            //MessageBox.Show(testCode + "" + userCode);
           int marks = 0;
            var Dbconnect = new ConnectionString();
            try
            {
                var connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect()); 
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                    "select SUM(mark) from [dbo].[UserMarks] where userid =(select id from Users where password='" +userCode + "') and testid=(select id from Test where testcode='" + testCode + "')";
                marks = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return marks;
        }


        public void CloseTimer()
        {
            if (time == 60)
            {
                closetime.Stop();
                var newLogin = new Login();
                Hide();
                Application.Exit();
                Application.Restart();
                
            }
        }

        //public decimal CalculateFinal(decimal score,decimal original)
        //{
        //    decimal percent = 0;
        //    decimal answer=0;
        //    answer= (score)/(original);
        //    percent = answer*100;
        //    return percent;
        //}


        private void UserResult_Load(object sender, EventArgs e)
        {
            userCode = new Login().getPasscode;
            testCode = new TestPage().getTestCode;


            closetime.Start();
            int mark = GetMarks();
            //int ori = new UserRemarks().GetOriginalScore(testCode);

            decimal finalMark = 0;
            Wrong = new UserRemarks().WrongAnswers(userCode, testCode);
            Correct = new UserRemarks().CorrectAnswers(userCode, testCode);
            finalMark = decimal.Round(mark);
            CorrectAnswer.Text = CorrectAnswer.Text + " " + Correct.ToString();
            WrongAnswer.Text = WrongAnswer.Text + " " + Wrong.ToString();

            int total = 0;
            total = Correct + Wrong;
            nonAnswered = new UserRemarks().CountQuestion(testCode) - total;
            UnAnswered.Text = UnAnswered.Text + " " + nonAnswered.ToString();

            Score.Text = Convert.ToString(finalMark);
            score = finalMark;
            if (score >= 25)
            {
                Score.ForeColor = Color.Green;
                Display.ForeColor = Color.Green;
            }
            if (score < 25 && score > 15)
            {
                Score.ForeColor = Color.Yellow;
                Display.ForeColor = Color.Yellow;
            }
            if (score < 15)
            {
                Score.ForeColor = Color.Red;
                Display.ForeColor = Color.Red;
            }

            new UserRemarks().SaveMarks(userCode, score, testCode);
            new UserRemarks().SaveUserStatus(userCode);
        }

        private void closetime_Tick(object sender, EventArgs e)
        {
            time++;
            CloseTimer();
        }
    }
}