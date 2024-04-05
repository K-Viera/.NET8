using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibraryTest.Generics
{
    public class Test
    {
        public string Topic { get; private set; }

        public float Percentaje { get; set; }

        public float Grade {  get; set; } 
        public Test(string topic)
        {
            Topic = topic;
        }

        public virtual float CalculateFinalGrade()
        {
            return Percentaje * Grade;
        }
    }
    public class WrittenTest : Test
    {
        public string Question { get; private set; }
        public WrittenTest(string topic, string question) : base(topic)
        {
            Question = question;
        }
    }
    public class MultipleSelectionExam : Test {
        public List<bool> Answers { get; private set; }
        public MultipleSelectionExam(string topic, List<bool> answers) : base(topic)
        {
            Answers = answers;
        }

        public override float CalculateFinalGrade()
        {
            int totalQuestion = Answers.Count;
            int totalCorrect = Answers.Where(x=>x.Equals(true)).Count();

            Grade = totalCorrect / totalQuestion * 5;

            return Percentaje * Grade;
        }
    }
}
