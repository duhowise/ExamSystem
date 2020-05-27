using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamSystem
{
    public partial class Admin : DevComponents.DotNetBar.OfficeForm
    {

 

        public Admin()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command = new SqlCommand("SELECT * FROM Users WHERE password='" + AdminCode.Text + "'AND UserType='Administrator'", connection);
                SqlDataReader datareader = command.ExecuteReader();
                int count = 0;
                while (datareader.Read())
                {
                    count = count + 1;
                }
                datareader.Close();

                if (count == 1)
                {
                    this.Hide();
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
