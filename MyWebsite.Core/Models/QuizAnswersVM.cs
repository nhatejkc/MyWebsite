using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Models
{
    public class QuizAnswersVM
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string AnswerQ { get; set; }
        public bool isCorrect { get; set; }
        
    }
}
