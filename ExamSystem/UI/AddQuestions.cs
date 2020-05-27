using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Logic;

namespace ExamSystem.UI
{
    public partial class AddQuestions : DevComponents.DotNetBar.OfficeForm
    {
        public AddQuestions()
        {
            InitializeComponent();     
        }

        public void LoadTest()
        {  
            ConnectionString Dbconnect = new ConnectionString();
            
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = new SqlCommand("SELECT * FROM Test", connection);
                SqlDataReader datareader = command.ExecuteReader();

                while (datareader.Read())
                {
                    string test = datareader.GetString(1);
                    TestName.Items.Add(test);
                    
                }
                datareader.Close();
                connection.Dispose();


            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        int queno = 1;
        int originalNumber;
        string testName=null;
        private void AddQuestions_Load(object sender, EventArgs e)
        {
            TestName.Items.Add("Select Subject");
            TestName.SelectedText = "Select Subject";
            LoadTest();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
               Save();
                RowCount();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void TestName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(TestName.SelectedItem) != "Select Subject")
            {
                GetTestDetails();
                AddingQuestions.Text = "Adding Questions For:" + " " + TestName.SelectedItem.ToString();
                int rowcount = RowCount();
                if (rowcount < 1 && originalNumber < 1)
                {
                    rowcount = 0;
                    originalNumber = 0;
                    QueNo.Text = "Added " + rowcount.ToString() + " of " + originalNumber + " Questions";
                }
                else
                {
                    QueNo.Text = "Added " + rowcount.ToString() + " of " + originalNumber + " Questions";
                }
            }
            else
            {
                QueNo.Text = "";
            }
            
        }

        public void Save()
        {

            if (QuestionText.Text == "" | OpAText.Text == "" | OpBText.Text == "" | Answer.Text == "" | TestName.SelectedItem.ToString() == "")
            {
                MessageBox.Show("The fields with asterisks are Required", "Fill all Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (OpBText.Text == OpAText.Text | OpBText.Text == OpCText.Text | OpBText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (OpAText.Text == OpBText.Text | OpAText.Text == OpCText.Text | OpAText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (OpCText.Text == OpAText.Text | OpCText.Text == OpBText.Text | OpCText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (OpDText.Text == OpAText.Text | OpDText.Text == OpBText.Text | OpDText.Text == OpCText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ConnectionString Dbconnect = new ConnectionString();
                try
                {

                    SqlConnection connection = new SqlConnection();
                    connection = new SqlConnection(Dbconnect.Connect());
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    string test = "select id from Question where testid=(select Id from test where name='" + TestName.SelectedItem.ToString() + "') and text='" + QuestionText.Text.ToString() + "' and opA='" + OpAText.Text.ToString() + "' ";
                    command = new SqlCommand(test, connection);
                    SqlDataReader datareader = command.ExecuteReader();
                    if (datareader.HasRows)
                    {

                        MessageBox.Show("Question already exists", "information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        string query = "insert into Question (testid,mark,[text],opA,opB,opC,opd,answer)values((select Id from test where name='" + TestName.SelectedItem.ToString() + "'),5,'" + QuestionText.Text.ToString() + "','" + OpAText.Text.ToString() + "','" + OpBText.Text.ToString() + "','" + OpCText.Text.ToString() + "','" + OpDText.Text.ToString() + "','" + Answer.SelectedItem.ToString() + "')";

                        command = new SqlCommand(query, connection);
                        int count = command.ExecuteNonQuery();


                        if (count == 1)
                        {
                            MessageBox.Show("Successfully Added Question", "information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QuestionText.Text = "";
                            OpAText.Text = "";
                            OpBText.Text = "";
                            OpCText.Text = "";
                            OpDText.Text = "";
                            Answer.SelectedItem = "";
                            TestName.SelectedItem = "";
                            queno = queno + 1;
                        }
                        connection.Dispose();
                    }

                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public int RowCount()
        {
            int row = 0;
            if (TestName.SelectedItem != null)
            {
                ConnectionString Dbconnect = new ConnectionString();
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection = new SqlConnection(Dbconnect.Connect());
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "select COUNT(*) from [dbo].[Question] where testid=(select id from test where name='" + TestName.SelectedItem.ToString() + "')";
                    row = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                }

                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Select a subject","Caution!");
            }
            return row;
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
                command = new SqlCommand("select name,NumberofQ from test where id=(select id from test where name='" + TestName.SelectedItem.ToString() + "')", connection);
                //MessageBox.Show(Pwd);
                SqlDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    testName = datareader.GetString(0);
                    originalNumber = datareader.GetInt32(1);

                }
                datareader.Close();
                connection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TestName.SelectedItem != null|RowCount()!=0)
            {
                if (RowCount() != originalNumber)
                {
                    Save();
                    RowCount();
                    QueNo.Text = "Added " + RowCount().ToString() + " of " + originalNumber + " Questions";

                }
                else
                {
                    MessageBox.Show("You have Already Set the Maximum Allowed Questions ", "Done!");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult logoutDialogResult= MessageBox.Show("Are you sure you want to logout ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (logoutDialogResult==DialogResult.OK)
            {
               Hide();
            }
        }
    }
}
