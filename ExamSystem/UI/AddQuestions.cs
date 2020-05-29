using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Services;

namespace ExamSystem.UI
{
    public partial class AddQuestions : DevComponents.DotNetBar.OfficeForm
    {
        private readonly ExamDatabase _database;
        private readonly TestService _testService;

        public AddQuestions(ExamDatabase database, TestService testService)
        {
            InitializeComponent();
            _database = database;
            _testService = testService;
        }

        public async Task LoadTest()
        {
            try
            {
                var tests =await _testService.GetAllTestNames();
                TestName.DataSource=tests;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int _queno = 1;
        int _originalNumber;
        string _testName = null;

        private void AddQuestions_Load(object sender, EventArgs e)
        {
         
            LoadTest().ConfigureAwait(false);
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
                AddingQuestions.Text = $@"Adding Questions For: {TestName.DisplayMember}";
                int rowcount = RowCount();
                if (rowcount < 1 && _originalNumber < 1)
                {
                    rowcount = 0;
                    _originalNumber = 0;
                    QueNo.Text = "Added " + rowcount.ToString() + " of " + _originalNumber + " Questions";
                }
                else
                {
                    QueNo.Text = "Added " + rowcount.ToString() + " of " + _originalNumber + " Questions";
                }
            }
            else
            {
                QueNo.Text = "";
            }
        }

        public void Save()
        {
            if (QuestionText.Text == "" | OpAText.Text == "" | OpBText.Text == "" | Answer.Text == "" |
                TestName.SelectedItem == null)
            {
                MessageBox.Show("The fields with asterisks are Required", "Fill all Required Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (OpBText.Text == OpAText.Text | OpBText.Text == OpCText.Text | OpBText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (OpAText.Text == OpBText.Text | OpAText.Text == OpCText.Text | OpAText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            else if (OpCText.Text == OpAText.Text | OpCText.Text == OpBText.Text | OpCText.Text == OpDText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (OpDText.Text == OpAText.Text | OpDText.Text == OpBText.Text | OpDText.Text == OpCText.Text)
            {
                MessageBox.Show("Provided Options Cannot be the same", "Check Provided Options", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    _testService.AddNewQuestion(new Question
                    {
                        Testid =(int) TestName.SelectedValue,
                        Mark = 5,
                        Text = QuestionText.Text,
                        OpA = OpAText.Text,
                        OpB = OpBText.Text,
                        OpC = OpCText.Text,
                        Opd = OpDText.Text,
                        Answer = Answer.SelectedItem.ToString()
                    });


                    MessageBox.Show("Successfully Added Question", "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    QuestionText.Text = "";
                    OpAText.Text = "";
                    OpBText.Text = "";
                    OpCText.Text = "";
                    OpDText.Text = "";
                    Answer.SelectedItem = "";
                    TestName.SelectedItem = "";
                    _queno = _queno + 1;
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        public int RowCount()
        {
           return _testService.GetCurrentNumberOfQuestionsSetForTest(Convert.ToInt32(TestName.SelectedValue));
        }

        public void GetTestDetails()
        {
            try
            {
               var test= _testService.GetTestDetails((int)TestName.SelectedValue);

               
                    _testName =test.Name;
                    if (test.NumberofQ != null) _originalNumber = test.NumberofQ.Value;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TestName.SelectedItem != null | RowCount() != 0)
            {
                if (RowCount() != _originalNumber)
                {
                    Save();
                    RowCount();
                    QueNo.Text = "Added " + RowCount().ToString() + " of " + _originalNumber + " Questions";
                }
                else
                {
                    MessageBox.Show("You have Already Set the Maximum Allowed Questions ", "Done!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult logoutDialogResult = MessageBox.Show("Are you sure you want to logout ?", "Logout",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (logoutDialogResult == DialogResult.OK)
            {
                Hide();
            }
        }
    }
}