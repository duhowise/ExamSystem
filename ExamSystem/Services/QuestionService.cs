using System;
using System.Linq;
using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class QuestionService
    {
        private readonly ExamDatabase _database;

        public QuestionService(ExamDatabase database)
        {
            _database = database;
        }

        

        
        public void InsertQuestionAnswer(AnsweredQuestion answeredQuestion)
        {
            try
            {
                var originalQuestion = _database.Questions.FirstOrDefault(x => x.Id == answeredQuestion.Questionid);
                if (originalQuestion == null) return;
                if (!string.Equals(originalQuestion.Answer.Trim(), answeredQuestion.Useranswer.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    _database.UserMarks.Add(new UserMark
                    {
                        Questionid = originalQuestion.Id,
                        Mark = 0,
                        Testid = originalQuestion.Testid,
                        Userid = Convert.ToInt32(answeredQuestion.Userid)
                    });
                }
                _database.AnsweredQuestions.Add(answeredQuestion);
                _database.UserMarks.Add(new UserMark
                {
                    Questionid = originalQuestion.Id,
                    Mark = 5,
                    Testid = originalQuestion.Testid,
                    Userid = Convert.ToInt32(answeredQuestion.Userid)
                });
                _database.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}