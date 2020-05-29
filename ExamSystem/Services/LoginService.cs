using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class LoginService
    {
        private readonly ExamDatabase _database;
        public LoginService(ExamDatabase database)
        {
            _database = database ;
        }

      

        public User Login(string userPass, string userType)
        {
            try
            {
               return _database.Users.Include(u => u.Test)
                    .FirstOrDefault(x => x.Password == userPass && x.UserType == userType);
            }
            catch (SqlException)
            {
                return null;
            }
        }

        
    }
}