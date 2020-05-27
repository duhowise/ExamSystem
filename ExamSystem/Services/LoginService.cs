using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using ExamSystem.Data;
using ExamSystem.Logic;

namespace ExamSystem.Services
{
    public class LoginService
    {
        private readonly ExamModel _database;

        public LoginService(ExamModel database)
        {
            _database = database;
        }

        public User Login(string userPass, string userType)
        {
            try
            {
               return _database.Users.Include(u => u.Test)
                    .FirstOrDefault(x => x.password == userPass && x.UserType == userType);
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public void UpdateUserStatus(User user)
        {
            try
            {
                var dbUser = _database.Users.Include(u => u.Test)
                    .FirstOrDefault(x => x.password == user.password && x.UserType == user.UserType);
                if (dbUser == null) return;
                user.status = "InProgress";
                _database.SaveChanges();
            }
            catch (SqlException)
            {
            }
        }

        
    }
}