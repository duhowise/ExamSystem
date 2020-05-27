using System;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class ViewResult : DevComponents.DotNetBar.OfficeForm
    {
        public ViewResult()
        {
            InitializeComponent();
        }

        private void ViewResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examDataSet.NamesTestsadnScores' table. You can move, or remove it, as needed.
            this.namesTestsadnScoresTableAdapter.Fill(this.examDataSet.NamesTestsadnScores);


        }
    }
}
