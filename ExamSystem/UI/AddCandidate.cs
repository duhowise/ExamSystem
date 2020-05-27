using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Logic;

namespace ExamSystem.UI
{
    public partial class AddCandidate : DevComponents.DotNetBar.OfficeForm
    {
        int count = 0;
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
               

                var dbconnect = new ConnectionString();
                try
                {
                    if (test!=null)
                    {
                        var connection = new SqlConnection();
                        connection = new SqlConnection(dbconnect.Connect());
                        connection.Open();
                        var command = new SqlCommand(test, connection);
                        var datareader = command.ExecuteReader();
                        if (datareader.HasRows)
                        {

                            MessageBox.Show("User already exists", "information!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (UserType.SelectedItem?.ToString() == "Administrator")
                            {
                                query = "INSERT INTO [dbo].[Users] ([name],[password],[UserType])values('" +
                                                   UserText.Text.ToString() + "','" + PasswordText.Text.ToString() + "','" +
                                                   UserType.SelectedItem.ToString() + "')";
                                command = new SqlCommand(query, connection);
                               count  = command.ExecuteNonQuery();
                            }
                            else
                            {
                               
                                if (userTest.SelectedItem!=null)
                                {
                                    query = "INSERT INTO [dbo].[Users] ([name],[password],[UserType],[testid])values('" +
                                                     UserText.Text.ToString() + "','" + PasswordText.Text.ToString() + "','" +
                                                     UserType.SelectedItem.ToString() + "',(select id from test where name='" + userTest.SelectedItem.ToString() + "'))";


                                }
                                else
                                {
                                    MessageBox.Show(@"Please Select the Test to which you are assigning the User", @"information!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                    return;
                                }
                                command = new SqlCommand(query, connection);
                                count = command.ExecuteNonQuery();
                            }
                            


                            if (count == 1)
                            {
                                MessageBox.Show("Successfully Added" + " " + UserText.Text.ToString(), "information!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                UserText.Text = "";
                                PasswordText.Text = "";
                                // UserType.SelectedItem = "";
                                UserType.Text = "";
                                userTest.Text = "";

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
    
        
        private static bool IsaDigit(Keys key)
        {
            if (key == Keys.Back||key==Keys.Space||key==Keys.CapsLock|| key == Keys.Shift)
            {
                return false;
            }
            return key <= Keys.D0 && key <= Keys.D9 || key >= Keys.NumPad0 && key <= Keys.NumPad9;
        }

        private void UserText_KeyDown(object sender, KeyEventArgs e)
        {
                var stat = IsaDigit(e.KeyData);
                if (!stat) return;
                MessageBox.Show(@"Only letters Allowed");
                UserText.Text="";


        }
    }
}
