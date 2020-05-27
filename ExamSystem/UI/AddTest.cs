using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExamSystem.Logic;

namespace ExamSystem.UI
{
    public partial class AddTest : DevComponents.DotNetBar.OfficeForm
    {
        public AddTest()
        {
            InitializeComponent();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            int ques=0,
                time = 0;
            if (Queno.Text!=""&&timetext.Text!="")
            {
               ques = Convert.ToInt32(Queno.Text);
                time = Convert.ToInt32(timetext.Text);
            }
            if (testNameText.Text==""|testCodeText.Text==""|timetext.Text==""|Queno.Text=="")
            {
                MessageBox.Show("Fields cannot be empty", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                    string test = "select id from Test where name='" + testNameText.Text.ToString() + "' and testcode='" + testCodeText.Text.ToString() + "'";
                    command = new SqlCommand(test, connection);
                    SqlDataReader datareader = command.ExecuteReader();
                    if (datareader.HasRows)
                    {

                        MessageBox.Show("Sorry this Subject Already exists", "information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    { 
                        string query = "INSERT INTO Test(name,testcode,NumberofQ,time)values('" + testNameText.Text.ToString() + "','" +testCodeText.Text.ToString() + "','" + ques + "','" + time + "')";
                   
                        command = new SqlCommand(query, connection);
                        int count = command.ExecuteNonQuery();


                        if (count == 1)
                        {
                            MessageBox.Show("Successfully Added Question", "information!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            testNameText.Text = "";
                            testCodeText.Text = "";
                            timetext.Text = "";
                            Queno.Text ="";

                        }
                        connection.Close();
                        connection.Dispose();
                    }
                }
                catch (Exception ){
                    MessageBox.Show("All Fields are Required", "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void AddTest_Load(object sender, EventArgs e)
        {

        }
    }
}
