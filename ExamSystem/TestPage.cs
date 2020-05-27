using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class TestPage : DevComponents.DotNetBar.OfficeForm
    {
        public static string testCode;
        public TestPage()
        {
            InitializeComponent();
        }
        public string getTestCode
        {
            set {testCode = value; }
            get { return testCode; }
           
        }

        string code;
        public void GetTest()
        {
            ConnectionString Dbconnect = new ConnectionString();
            if (TestCode.Text == "")
            {
                MessageBox.Show("Please Enter A Subject Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestCode.Focus();
                return;
            }
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = new SqlCommand("SELECT * FROM test WHERE testcode='" + TestCode.Text + "'", connection);
                SqlDataReader datareader = command.ExecuteReader();
                int count = 0;
                while (datareader.Read())
                {
                    count = count + 1;
                }
                datareader.Close();
                connection.Close();

                if (count == 1)
                {
                    this.Hide();
                    //QuestionPage questionPage = new QuestionPage();
                    //questionPage.Show();
                    QuestionPage question = new QuestionPage();
                    question.passCode = TestCode.Text.ToString();
                    question.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Passcode", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            testCode = TestCode.Text.ToString();
            GetTest();
        }

        private void TestPage_Load(object sender, EventArgs e)
        {

        }
    }
  
}
