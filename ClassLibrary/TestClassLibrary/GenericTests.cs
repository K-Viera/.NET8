using ClassLibraryTest.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TestClassLibrary
{
    public class GenericTests
    {
        [Fact]
        public void ExcellentNotesReturnExcellent()
        {
            //Arrange
            float excellentNote = 5;

            //Initialize MathSubjectTests
            MathSubjectTests mathTests = new MathSubjectTests();
            WrittenTest writtenTest = new WrittenTest("Algebra", "Solve for x: 2x + 5 = 15");
            writtenTest.Percentaje = 0.5f;
            writtenTest.Grade = excellentNote;
            mathTests.Tests.Add(writtenTest);

            // Adding MultipleSelectionExam
            List<bool> answers = new List<bool> { true, true, true, true };
            MultipleSelectionExam multipleSelectionExam = new MultipleSelectionExam("Geometry", answers, excellentNote);
            multipleSelectionExam.Percentaje = 0.5f;
            mathTests.Tests.Add(multipleSelectionExam);

            //Act
            var final = FinalCalificationService<MathSubjectTests>.GetFinal(mathTests);

            //Assert
            Assert.Equal(excellentNote, final);
        }

        [Fact]
        public void BadNotesReturnBad()
        {
            //Arrange
            float excellentNote = 5;
            float badNote = 0;

            //Initialize MathSubjectTests
            MathSubjectTests mathTests = new MathSubjectTests();
            WrittenTest writtenTest = new WrittenTest("Algebra", "Solve for x: 2x + 5 = 15");
            writtenTest.Percentaje = 0.5f;
            writtenTest.Grade = badNote;
            mathTests.Tests.Add(writtenTest);

            // Adding MultipleSelectionExam
            List<bool> answers = new List<bool> { false, false, false, false };
            MultipleSelectionExam multipleSelectionExam = new MultipleSelectionExam("Geometry", answers, excellentNote);
            multipleSelectionExam.Percentaje = 0.5f;
            mathTests.Tests.Add(multipleSelectionExam);

            //Act
            var final = FinalCalificationService<MathSubjectTests>.GetFinal(mathTests);

            //Assert
            Assert.Equal(badNote, final);
        }
        [Fact]
        public void NotFullPercentaje()
        {
            //Arrange
            float excellentNote = 5;
            float badNote = 0;

            //Initialize MathSubjectTests
            MathSubjectTests mathTests = new MathSubjectTests();
            WrittenTest writtenTest = new WrittenTest("Algebra", "Solve for x: 2x + 5 = 15");
            writtenTest.Percentaje = 0.5f;
            writtenTest.Grade = badNote;
            mathTests.Tests.Add(writtenTest);

            // Adding MultipleSelectionExam
            List<bool> answers = new List<bool> { false, false, false, false };
            MultipleSelectionExam multipleSelectionExam = new MultipleSelectionExam("Geometry", answers, excellentNote);
            multipleSelectionExam.Percentaje = 0.2f;
            mathTests.Tests.Add(multipleSelectionExam);

            //Assert
            Assert.Throws<NotFullPercejateException>(() => FinalCalificationService<MathSubjectTests>.GetFinal(mathTests));
        }
    }
}
