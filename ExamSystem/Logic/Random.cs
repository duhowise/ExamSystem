using System;
using System.Collections.Generic;
using ExamSystem.Data;
using ExamSystem.Services;

namespace ExamSystem.Logic
{
    public class Yates
    {
        private static Random rand = new Random();

        public Stack<Question> ShuffleQuestions(List<Question> questions)
        {
            for (var i = questions.Count - 1; i > 0; i--)
            {
                var j = rand.Next(i + 1);
                var temp = questions[i];
                questions[i] = questions[j];
                questions[j] = temp;
            }

            return Assign(questions, new Stack<Question>());
        }

        private static Stack<Question> Assign(IEnumerable<Question> value, Stack<Question> questions)
        {
            foreach (var num in value)
            {
                questions.Push(num);
            }

            return questions;
        }
    }
}