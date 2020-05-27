using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class QuestionService
    {
        private ExamModel _database;

        public QuestionService(ExamModel database)
        {
            _database = database;
        }

        

        public Test GetTestDetails(string testCode)
        {
            try
            {
                return _database.Tests.Include(x=>x.Questions).FirstOrDefault(x => x.testcode == testCode);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message,exception);
            }
        }
        public void InsertQuestionAnswer(AnsweredQuestion question)
        {
            try
            {
                _database.AnsweredQuestions.Add(question);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}