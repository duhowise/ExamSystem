using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class QuestionPage : DevComponents.DotNetBar.OfficeForm
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        public string Pwd = null;
        private bool state;
        public static int[] number;
        public static int Count = 0;
        public int questionNumber, originalNumber;
        public string userid=null, testName=null,passcode=null;
        int hh=0,mm=0,ss=0;
        public string passCode
        {
            get { return Pwd; }
            set { Pwd = value; }
        }
        public int getNumber(int count)
        {
            int holder = 0;
            holder = number[count];
            return holder;
        }
        public static void setNumber()
        {
            for (int i = 0; i < number.Length; i++)
            {
                number.SetValue(i + 1, i);
            }
        }
        public void GetTestDetails()
        {
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = new SqlCommand("select name,NumberofQ,time from test where id=(select id from Test where testcode='" + Pwd + "')", connection);
                //MessageBox.Show(Pwd);
                SqlDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    testName = datareader.GetString(0);
                    originalNumber = datareader.GetInt32(1);
                    mm = datareader.GetInt32(2);

                }
                datareader.Close();
                connection.Close();
                number = new int[originalNumber + 1];
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public void GetQuestion()
        {
            questionNumber = getNumber(Count);
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = new SqlCommand("select * from Question where id='" + questionNumber + "' and testid=(select id from Test where testcode='" + Pwd + "')", connection);
                //MessageBox.Show(Pwd);
                SqlDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    string question = datareader.GetString(3);
                    string a = datareader.GetString(4);
                    string b = datareader.GetString(5);
                    string c = datareader.GetString(6);
                    string d = datareader.GetString(7);
                    QuestionLabel.Text = question;
                    OptionA.Text = a;
                    OptionB.Text = b;
                    OptionC.Text = c;
                    OptionD.Text = d;

                    OptionState();
                    state = true;
                }
                datareader.Close();

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
                MessageBox.Show("You have to choose an Answer", "sorry");
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
        public void InsertAnswer()
        {
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                SqlCommand command = new SqlCommand();
                string query = "insert into answeredquestions([temp],[useranswer],[tempass])values('" + QuestionLabel.Text + "','" + SetAnswer() + "','" + passcode + "')";
                command = new SqlCommand(query, connection);
                SqlDataReader datareader = command.ExecuteReader();
                Count++;
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //public void ComputeMarks()
        //{
        //    ConnectionString Dbconnect = new ConnectionString();
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection();
        //        connection = new SqlConnection(Dbconnect.Connect());
        //        connection.Open();
        //        SqlCommand command = new SqlCommand();
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.CommandText = "AllocateUserMarks";
        //        SqlParameter parameter = new SqlParameter();
        //        parameter.ParameterName = "@Userid";
        //        parameter.Value = passcode;
        //        command.Parameters.Add(parameter);
        //        command.Connection = connection;
        //        command.ExecuteNonQuery();
        //        connection.Close();
        //    }

        //    catch (SqlException exception)
        //    {
        //        MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        public void HideControls()
        {
            OptionA.Visible = false;
            OptionB.Visible = false;
            OptionC.Visible = false;
            OptionD.Visible = false;
            QuestionLabel.Visible = false;
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            TestTime.Enabled = true;
            Start.Visible = false;
            Welcome.Visible = false;
            GetQuestion();
            OK.Visible = true;
            ShowControls();
            OptionState();
        }

        private void TestTime_Tick_1(object sender, EventArgs e)
        {
            ss = ss - 1;
            string s = Convert.ToString(ss);
            Seclabel.Text = s;
            string h = Convert.ToString(hh);
            Hourlabel.Text = h;
            string m = Convert.ToString(mm);
            Minlabel.Text = m;
            if (ss == -1)
            {
                mm = mm - 1;
                ss = 59;
            }
            if (mm == -1)
            {
                hh = hh - 1;
                mm = 59;
            }
            if (hh == 0 && mm == 0 && ss == 0)
            {
                TestTime.Stop();
                DialogResult done = MessageBox.Show("Please your time is up click ok to display your Results",
                    "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (done == DialogResult.OK)
                {
                    Hide();
                    UserResult result = new UserResult();
                    result.Show();
                }

            }
        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            if (SetAnswer() != null)
            {
                DialogResult sure = MessageBox.Show("Are You Sure " + SetAnswer() + " is the Answer ?", "Confirm", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes & state == true)
                {
                    if (Count != originalNumber)
                    {
                        InsertAnswer();
                        GetQuestion();
                        OptionState();
                    }
                    else
                    {
                        DialogResult Complete = MessageBox.Show("You Have Successfully Completed the Test", "Confirm",
                            MessageBoxButtons.OK);
                        if (Complete == DialogResult.OK)
                        {
                            UserResult showResult = new UserResult();
                            showResult.Show();
                            Close();
                        }

                    }

                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Count != originalNumber)
            {
                InsertAnswer();
                GetQuestion();
                OptionState();
            }
        }

        public void ShowControls()
        {
            OptionA.Visible = true;
            OptionB.Visible = true;
            OptionC.Visible = true;
            OptionD.Visible = true;
            QuestionLabel.Visible = true;
        }


        private void OK_Click(object sender, EventArgs e)
        {
            if (SetAnswer() != null)
            {
                DialogResult sure = MessageBox.Show("Are You Sure " + SetAnswer() + " is the Answer ?", "Confirm", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes & state == true)
                {
                    if (Count != originalNumber)
                    {
                        InsertAnswer();
                        GetQuestion();
                        OptionState();
                    }
                    else
                    {
                        DialogResult Complete = MessageBox.Show("You Have Successfully Completed the Test", "Confirm",
                            MessageBoxButtons.OK);
                        if (Complete == DialogResult.OK)
                        { 
                            UserResult showResult = new UserResult();
                            showResult.Show();
                            Close();
                        }

                    }

                }
            }
        }

       
        private void TestTime_Tick(object sender, EventArgs e)
        {
            ss = ss - 1;
            string s = Convert.ToString(ss);
            Seclabel.Text = s;
            string h = Convert.ToString(hh);
            Hourlabel.Text = h;
            string m = Convert.ToString(mm);
            Minlabel.Text = m;
            if (ss == -1)
            {
                mm = mm - 1;
                ss = 59;
            }
            if (mm == -1)
            {
                hh = hh - 1;
                mm = 59;
            }
            if (hh == 0 && mm == 0 && ss == 0)
            {
                TestTime.Stop();
                DialogResult done = MessageBox.Show("Please your time is up click ok to display your Results",
                    "Times Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (done == DialogResult.OK)
                {
                    Hide();
                    UserResult result = new UserResult();
                    result.Show();
                }

            }

        }

    
        private void Start_Click(object sender, EventArgs e)
        {
            TestTime.Enabled = true;
            Start.Visible = false;
            Welcome.Visible = false;
            GetQuestion();
            OK.Visible = true;
            ShowControls();
            OptionState();
        }

        private void QuestionPage_Load(object sender, EventArgs e)
        {
            GetTestDetails();
            Welcome.Text = "Welcome to the " + testName + " Test!" + "Press Start when Ready";
            setNumber();
            Shuffle.DoShuffle(number);
            OK.Visible = false;
            Start.Visible = true;
            HideControls();
            OptionState();
            Login log = new Login();
            passcode = log.getPasscode;
        }
    }
}
