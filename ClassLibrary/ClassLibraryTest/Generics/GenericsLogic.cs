using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest.Generics
{
    public class GenericsLogic : ILogic
    {
        public string _name = "Generics";
        public string Name => _name;

        public void ExecuteLogic()
        {
            //Initialize MathSubjectTests
            MathSubjectTests mathTests = new MathSubjectTests();

            WrittenTest writtenTest = new WrittenTest("Algebra", "Solve for x: 2x + 5 = 15");
            writtenTest.Percentaje = 0.5f;
            writtenTest.Grade = 1; 
            mathTests.Tests.Add(writtenTest);

            // Adding MultipleSelectionExam
            List<bool> answers = new List<bool> { true, true, true, true };
            MultipleSelectionExam multipleSelectionExam = new MultipleSelectionExam("Geometry", answers,5);
            multipleSelectionExam.Percentaje = 0.5f;
            mathTests.Tests.Add(multipleSelectionExam);

            var final = FinalCalificationService<MathSubjectTests>.GetFinal(mathTests);

            Console.WriteLine("Final calification is");
            Console.WriteLine(final);
        }
    }
}
