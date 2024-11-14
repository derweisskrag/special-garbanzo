using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Question
    {
        public string Title { get; set; }
        public string[] Options { get; set; }
        public char CorrectAnswer { get; set;  }

        public char UserAnswer { get; set; }

        public Question(string title, string[] options, char correctAnswer)
        {
            Title = title;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
