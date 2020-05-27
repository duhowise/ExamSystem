using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class AddCandidate : DevComponents.DotNetBar.OfficeForm
    {
        public AddCandidate()
        {
            InitializeComponent();
        }
        public string test = null;
        public string GeneratePasscode()
        {
            int length = 8;
            string range = "123456789abcdefghijklmnpqrstuvwxyzABCDEFGHIJKLMNPQRSTUVWXYZ";
            char[] chars = new char[length];
            Random r=new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = range[r.Next(0, range.Length)];
            }

            return new string(chars);
        }


        private void AddCandidate_Load(object sender, EventArgs e)
        {
            userTest.Visible = false;
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
                    userTest.Items.Add(test);

                }
                datareader.Close();
                connection.Dispose();


            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = null;


            if (UserType.SelectedItem!=null|UserText.Text!=null|PasswordText.Text!=null)
            {
               

                ConnectionString Dbconnect = new ConnectionString();
                try
                {
                    if (test!=null)
                    {
                        SqlConnection connection = new SqlConnection();
                        connection = new SqlConnection(Dbconnect.Connect());
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command = new SqlCommand(test, connection);
                        SqlDataReader datareader = command.ExecuteReader();
                        if (datareader.HasRows)
                        {

                            MessageBox.Show("User already exists", "information!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (UserType.SelectedItem.ToString() == "Administrator")
                            {
                                query = "INSERT INTO [dbo].[Users] ([name],[password],[UserType])values('" +
                                                   UserText.Text.ToString() + "','" + PasswordText.Text.ToString() + "','" +
                                                   UserType.SelectedItem.ToString() + "')";
                            }
                            else
                            {
                                query = "INSERT INTO [dbo].[Users] ([name],[password],[UserType],[testid])values('" +
                                                   UserText.Text.ToString() + "','" + PasswordText.Text.ToString() + "','" +
                                                   UserType.SelectedItem.ToString() + "',(select id from test where name='" + userTest.SelectedItem.ToString() + "'))";
                            }
                            command = new SqlCommand(query, connection);
                            int count = command.ExecuteNonQuery();


                            if (count == 1)
                            {
                                MessageBox.Show("Successfully Added" + " " + UserText.Text.ToString(), "information!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                UserText.Text = "";
                                PasswordText.Text = "";
                                UserType.SelectedItem = "";
                            }
                            connection.Close();
                            connection.Dispose();
                        }

                    }


                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserText.Text = "";
                    PasswordText.Text = "";
                    UserType.SelectedItem = "";

                }

            }
            else
            {
                MessageBox.Show("Check All Fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UserText.Text = "";
                PasswordText.Text = "";
                UserType.SelectedItem = "";
            }


            //if (UserText.Text.ToString()==""| PasswordText.Text.ToString() =="" )
            //{
            //    MessageBox.Show("All Fields are Required ", "Check Provided Options", MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //}
            //else
            //{

            //}
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {  test= "select id from Users where name='" + UserText.Text.ToString() + "' and UserType='" +
                                 UserType.SelectedItem.ToString() + "'";
            if (UserType.SelectedItem.ToString()=="User")
            {
                userTest.Visible = true;
            }
            else
            {
                userTest.Visible = false;
                userTest.SelectedItem = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasswordText.Text =GeneratePasscode();
        }


    }
}
