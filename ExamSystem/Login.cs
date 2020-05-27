using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamSystem
{
    
    public partial class Login : DevComponents.DotNetBar.OfficeForm
    {
        public Login()
        {
            InitializeComponent();
            
        }

        public static string pass;
        public string getPasscode
        {
           
            get { return pass; }

            set { pass = value; }
        }

        
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.Hide();
            Admin forAdmin = new Admin();
            forAdmin.Show();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Enter))
            {
                login(pass);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void login(string userPass)
        {
            ConnectionString Dbconnect = new ConnectionString();
            if (Usercode.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usercode.Focus();
                return;
            }
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();

                SqlCommand command = new SqlCommand();

                command = new SqlCommand("SELECT * FROM Users WHERE password='" + userPass + "'AND UserType='user'", connection);
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
                    QuestionPage quest = new QuestionPage();
                    TestPage testPage = new TestPage();
                    this.Hide();
                    testPage.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Passcode", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Usercode.Text = "";
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pass = Usercode.Text.ToString();
            string status = new UserRemarks().CheckUserStatus(pass);
            if (status != "Completed")
            {
                login(pass);
            }
            else
            {
                MessageBox.Show("You Have Already Taken The Test", "Caution",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Usercode.Text = "";
            }
            
          
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            new IPAdress().CreateFile();
        }

        private void Codelabel_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
