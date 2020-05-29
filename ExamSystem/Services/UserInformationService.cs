using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public  class UserInformationService
    {
        private readonly ExamDatabase _database;

        public UserInformationService(ExamDatabase database)
        {
            _database = database;
        }
        public  List<NamesTestsadnScore> GetUserNamesAndTestScores()
        {
            
            try
            {

              return _database.Users.Where(x=>x.UserType!= "Administrator").Include(x => x.UserMarks).ToList().Select(x => new NamesTestsadnScore
                {
                    Id = x.Id,
                    NameOfStudent = x.Name,
                    TestTaken = x.Test.Name,
                    Marks = x.UserMarks.Sum(m=>m.Mark)
                }).ToList(); ;
                
            }
            catch (SqlException)
            {
                return new List<NamesTestsadnScore>();

            }
        }

        public List<UserInformation> GetUserInformation()
        {
           return _database.Users.ToList().Select(x => new UserInformation{
               Name = x.Name,
               Status = x.Status,
               Password = x.Password
               
           }).ToList();

        }
    }




    //CREATE VIEW UserInformation AS
    //SELECT u.name AS 'NAME', u.password AS 'PASSWORD', u.status AS 'STATUS' FROM Users u
    //WHERE u.UserType= 'User'
}