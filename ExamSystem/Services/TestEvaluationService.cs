using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    class TestEvaluationService
    {
        private readonly ExamModel _database;

        public TestEvaluationService(ExamModel database)
        {
            _database = database;
        }
        public void SaveUserStatus(User user)
        {
            try
            {
               var dbEntry= _database.Users.FirstOrDefault(x => x.UserType == user.UserType && x.password == user.password);
               if (dbEntry == null)
               {
                   throw new Exception("could not save status to database");
               }
               dbEntry.status = "Completed";
               _database.SaveChanges();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        public void SaveMarks(string usercode,decimal Marks,string testCode)
        {
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                SqlCommand command = new SqlCommand();
                string query = $"insert into totalMarks([userid],[testid],[marks])values((select id from Users where password='{usercode}'),(select id from Test where testcode='{testCode}'),'{Marks}' )";
                command = new SqlCommand(query, connection);
                SqlDataReader datareader = command.ExecuteReader();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
             
        public string CheckUserStatus(string usercode)
        {
            string status = null;
            ConnectionString Dbconnect = new ConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                SqlCommand command = new SqlCommand();
                string query = "select [status] from [dbo].[Users] where [Id]=(select id from Users where password='" + usercode + "')  ";
                command = new SqlCommand(query, connection);
                SqlDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    status = datareader.GetString(0);
                }
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return status;
        }

        public int GetOriginalScore(string testCode)
        {
            int count = 0;
            var Dbconnect = new ConnectionString();
            try
            {
                var connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                "select SUM(mark) from [dbo].[Question] where testid =(select id from Test where testcode='" + testCode + "')";
                count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return count;
        }

        public int CorrectAnswers(string usercode, string testCode)
        {
            int answers = 0;
            //getCorrectAnswers From Database
            var Dbconnect = new ConnectionString();
            try
            {
                var connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                " SELECT COUNT(UserMarks.Mark)FROM UserMarks where testid =(select id from Test where testcode='" + testCode + "') and userid=(select id from Users where password='" + usercode + "') and mark=1  ";
               answers = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return answers;
        }

        public int WrongAnswers(string usercode, string testCode)
        {
            int answers = 0;
            var Dbconnect = new ConnectionString();
            try
            {
                var connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                " SELECT COUNT(UserMarks.Mark)FROM UserMarks where testid =(select id from Test where testcode='" + testCode + "') and userid=(select id from Users where password='" + usercode + "') and mark=0  ";
                answers = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return answers;
        }

        public int CountQuestion(string testCode)
        {
            int count = 0;
            var Dbconnect = new ConnectionString();
            try
            {
                var connection = new SqlConnection();
                connection = new SqlConnection(Dbconnect.Connect());
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText =
                "select count(mark) from [dbo].[Question] where testid =(select id from Test where testcode='" + testCode + "')";
                count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }

            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "information!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return count;
        }
    }
}
