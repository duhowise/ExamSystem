using System;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class AddTest : DevComponents.DotNetBar.OfficeForm
    {
        private readonly TestService _testService;

        public AddTest(TestService testService)
        {
            _testService = testService;
            InitializeComponent();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            int ques = 0,
                time = 0;
            if (Queno.Text != "" && timetext.Text != "")
            {
                ques = Convert.ToInt32(Queno.Text);
                time = Convert.ToInt32(timetext.Text);
            }

            if (testNameText.Text == "" || testCodeText.Text == "" || timetext.Text == "" || Queno.Text == "")
            {
                MessageBox.Show("Fields cannot be empty", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    _testService.AddNewTest(new Test
                    {
                        Name = testNameText.Text,
                        Testcode = testCodeText.Text,
                        NumberofQ = ques,
                        Time = time
                    });


                    MessageBox.Show("Successfully Added Question", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    testNameText.Text = "";
                    testCodeText.Text = "";
                    timetext.Text = "";
                    Queno.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("All Fields are Required", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AddTest_Load(object sender, EventArgs e)
        {
        }
    }
}