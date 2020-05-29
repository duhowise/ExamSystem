using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Data;

namespace ExamSystem.UI
{
    public partial class AddCandidate : DevComponents.DotNetBar.OfficeForm
    {
        private readonly ExamDatabase _database;


        int _count = 0;

        public AddCandidate(ExamDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        public string UserId = null;

        public string GeneratePasscode()
        {
            int length = 8;
            string range = "123456789abcdefghijklmnpqrstuvwxyzABCDEFGHIJKLMNPQRSTUVWXYZ";
            char[] chars = new char[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                chars[i] = range[r.Next(0, range.Length)];
            }

            return new string(chars);
        }


        private void AddCandidate_Load(object sender, EventArgs e)
        {
            userTest.Visible = false;

            try
            {
                var testNames = _database.Tests.ToList();

                userTest.DataSource = testNames;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserType.SelectedItem != null | UserText.Text != null | PasswordText.Text != null)
            {
                try
                {
                    var user = _database.Users.FirstOrDefault(x =>
                        x.Password == PasswordText.Text && x.Name == UserType.Text);
                    if (user != null)
                    {
                        MessageBox.Show("User already exists", "information!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (UserType.SelectedItem?.ToString() == "Administrator")
                        {
                            _database.Users.Add(new User
                            {
                                Name = UserText.Text,
                                Password = PasswordText.Text,
                                UserType = "Administrator"
                            });
                        }
                        else
                        {
                            _database.Users.Add(new User
                            {
                                Name = UserText.Text,
                                Password = PasswordText.Text,
                                UserType = UserType?.SelectedItem?.ToString(),
                               Testid = (int)userTest.SelectedValue
                            });
                        }


                        _database.SaveChanges();


                        MessageBox.Show($@"Successfully Added {UserText.Text}", "information!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        UserText.Text = "";
                        PasswordText.Text = "";
                        UserType.SelectedIndex = 0;
                        UserType.Text = "";
                        userTest.Text = "";
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
        }

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserType.SelectedItem.ToString() == "User")
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
            PasswordText.Text = GeneratePasscode();
        }


        private static bool IsaDigit(Keys key)
        {
            if (key == Keys.Back || key == Keys.Space || key == Keys.CapsLock || key == Keys.Shift)
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
            UserText.Text = "";
        }
    }
}