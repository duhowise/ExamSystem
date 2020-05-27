using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public  class UserInformationService
    {
        private readonly ExamModel _database;

        public UserInformationService(ExamModel database)
        {
            _database = database;
        }
        public  List<UserInformation> GetUserData()
        {
            
            try
            {
                return _database.UserInformation.ToList();

            }
            catch (SqlException)
            {
                return new List<UserInformation>();

            }
        } 
    }
}