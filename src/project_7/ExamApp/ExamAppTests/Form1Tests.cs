using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        // Correct answers for all questions
        private readonly char[] CorrectAnswers = {
            'C', 'B', 'B', 'C', 'B', 'A', 'B', 'C', 'D', 'B',
            'B', 'B', 'B', 'D', 'C', 'B', 'A', 'B', 'A', 'B'
        };


        [TestMethod()]
        public void Form1Test()
        {
        }


        [DataTestMethod]
        [DataRow(new char[] { 'C', 'B', 'B', 'C', 'B', 'A', 'B', 'C', 'D', 'B', 'B', 'B', 'B', 'D', 'C', 'B', 'A', 'B', 'A', 'B' }, 20)] // All answers correct
        [DataRow(new char[] { 'A', 'B', 'B', 'C', 'B', 'A', 'C', 'D', 'A', 'B', 'B', 'B', 'D', 'C', 'B', 'B', 'A', 'B', 'A', 'C' }, 12)] // 12 correct answers
        [DataRow(new char[] { 'C', 'B', 'A', 'D', 'B', 'A', 'B', 'A', 'B', 'D', 'C', 'A', 'B', 'C', 'D', 'A', 'A', 'C', 'A', 'B' }, 9)] // 9 correct answers
        [DataRow(new char[] { 'A', 'A', 'A', 'A', 'A', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'A', 'B', 'A' }, 0)] // All incorrect
        [DataRow(new char[] { 'C', 'B', 'B', 'D', 'A', 'A', 'B', 'C', 'D', 'B', 'C', 'B', 'C', 'B', 'A', 'D', 'A', 'C', 'A', 'D' }, 11)] // 11 correct answers
        public void CalculateScoreTest(char[] userAnswers, int expectedScore)
        {
            // Arrange
            Exam exam = new Exam();
            exam.questions = CorrectAnswers.Select((answer, index) => new Question(
                $"Question {index + 1}",
                new string[] { "A", "B", "C", "D" },
                answer
            )).ToList();

            // Act
            int actualScore = exam.CalculateScore(userAnswers);

            // Assert
            Assert.AreEqual(expectedScore, actualScore, $"Expected score: {expectedScore}, but got: {actualScore}.");
        }
    }
}