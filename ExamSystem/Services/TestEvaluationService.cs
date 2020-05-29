using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class TestEvaluationService
    {
        private readonly ExamDatabase _database;

        public TestEvaluationService(ExamDatabase database)
        {
            _database = database;
        }

        public void SaveUserStatus(User user)
        {
            try
            {
                var dbEntry =
                    _database.Users.FirstOrDefault(x => x.UserType == user.UserType && x.Password == user.Password);
                if (dbEntry == null)
                {
                    throw new Exception("could not save status to database");
                }

                dbEntry.Status = "Completed";
                _database.SaveChanges();
            }

            catch (SqlException exception)
            {
                throw new ApplicationException(exception.Message, exception);
            }
        }

        public void UserInProgress(User user)
        {
            try
            {
                var dbEntry =
                    _database.Users.FirstOrDefault(x => x.UserType == user.UserType && x.Password == user.Password);
                if (dbEntry == null)
                {
                    throw new Exception("could not save status to database");
                }

                dbEntry.Status = "InProgress";
                _database.SaveChanges();
            }

            catch (SqlException exception)
            {
                throw new ApplicationException(exception.Message, exception);
            }
        }

        public void SaveMarks(decimal marks, int testId, int userId)
        {
            try
            {
                _database.TotalMarks.Add(new TotalMark
                    {Marks = marks.ToString(CultureInfo.InvariantCulture), Testid = testId, Userid = userId});
                _database.SaveChanges();
            }

            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public string CheckUserStatus(int userId)
        {
            try
            {
                var user = _database.Users.FirstOrDefault(x => x.Id == userId);
                return user?.Status;
            }
            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public string CheckUserStatus(string password)
        {
            try
            {
                var user = _database.Users.FirstOrDefault(x => x.Password == password);
                return user?.Status;
            }
            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public int GetTotalMarksAssignedToTest(int testId)
        {
            try
            {
                var marks = _database.UserMarks.Where(x => x.Testid == testId);
                return marks.Sum(x => x.Mark);
            }

            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public int GetAllCorrectAnswersForUser(int testId, int userId)
        {
            try
            {
                return _database.UserMarks.Count(x => x.Userid == userId && x.Testid == testId && x.Mark > 0);
            }

            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public int GetAllWrongAnswersForUser(int userId, int testId)
        {
            try
            {
                return _database.UserMarks.Count(x => x.Userid == userId && x.Testid == testId && x.Mark == 0);
            }

            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public int GetTotalNumberOfQuestionForTest(int testId)
        {
            try
            {
                return _database.UserMarks.Count(x => x.Testid == testId);
            }
            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }

        public int GetTotalMarksForUser(int userId, int testId)
        {
            try
            {
                var marks = _database.UserMarks.Where(x => x.Testid == testId && x.Userid == userId)
                    .Select(x => x.Mark);
                return marks.Sum();
            }

            catch (SqlException exception)
            {
                throw new InstanceNotFoundException(exception.Message, exception);
            }
        }
    }
}