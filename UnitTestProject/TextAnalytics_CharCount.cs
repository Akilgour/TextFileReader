using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileReader;

namespace UnitTestProject
{
    [TestClass]
    public class TextAnalytics_CharCount
    {

        [TestMethod]
        public void ReadEmptyString()
        {
            //Arrange 
            var value = "";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(0, charCount);
        }

        [TestMethod]
        public void ReadThreeChar()
        {
            //Arrange 
            var value = "ABC";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(3, charCount);
        }

        [TestMethod]
        public void ReadThreeCharWithSpaces()
        {
            //Arrange 
            var value = "A B C ";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(3, charCount);
        }

        [TestMethod]
        public void ReadThreeCharWithTabAtStart()
        {
            //Arrange 
            var value = "\tABC";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(3, charCount);
        }

        [TestMethod]
        public void ReadThreeCharWithTabAtMiddle()
        {
            //Arrange 
            var value = "A\tBC";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(3, charCount);
        }

        [TestMethod]
        public void ReadThreeCharWithTabAtEnd()
        {
            //Arrange 
            var value = "ABC\t";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charCount = textAnalytics.CharCount();

            //Assert
            Assert.AreEqual(3, charCount);
        }
    }
}
