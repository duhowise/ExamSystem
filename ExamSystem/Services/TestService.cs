using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class TestService
    {
        private readonly ExamDatabase _database;

        public TestService(ExamDatabase database)
        {
            _database = database;
        }


        public async Task<List<Test>> GetAllTestNames()
        {
            try
            {
                return await _database.Tests.ToListAsync();
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }

        public void AddNewQuestion(Question question)
        {
            try
            {
                if (_database.Questions.Any(x => x.Text == question.Text && x.Testid == question.Testid))
                {
                    throw new SqlAlreadyFilledException("data already exists");
                }

                _database.Questions.Add(question);
                _database.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }

        public int GetCurrentNumberOfQuestionsSetForTest(int testId)
        {
            try
            {
                return _database.Questions.Count(x => x.Testid == testId);
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }

        public Test GetTestDetails(int testId)
        {
            try
            {
                return _database.Tests.FirstOrDefault(x => x.Id == testId);
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }

        public Test GetTestDetails(string testCode)
        {
            try
            {
                return _database.Tests.FirstOrDefault(x => x.Testcode == testCode);
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }

        public void AddNewTest(Test test)
        {
            try
            {
                if (_database.Tests.Any(x => x.Testcode == test.Testcode))
                {
                    throw new SqlAlreadyFilledException("data already exists");
                }

                _database.Tests.Add(test);
                _database.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NullReferenceException(e.Message, e);
            }
        }
    }
}