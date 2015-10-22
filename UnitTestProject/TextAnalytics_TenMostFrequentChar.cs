using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileReader;

namespace UnitTestProject
{
    [TestClass]
   public class TextAnalytics_TenMostFrequentChar
    {

        [TestMethod]
        public void ReadThreeChar()
        {
            //Arrange 
            var value = "ABC";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charDictionary = textAnalytics.TenMostFrequentChar();

            //Assert
            Assert.AreEqual(3, charDictionary.Count);
            Assert.AreEqual(1, charDictionary['A']);
            Assert.AreEqual(1, charDictionary['B']);
            Assert.AreEqual(1, charDictionary['C']);
        }

        [TestMethod]
        public void ReadSameThreeChar()
        {
            //Arrange 
            var value = "AAA";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charDictionary = textAnalytics.TenMostFrequentChar();

            //Assert
            Assert.AreEqual(1, charDictionary.Count);
            Assert.AreEqual(3, charDictionary['A']);
        }

        [TestMethod]
        public void ReadThreeWithDuplicateChar()
        {
            //Arrange 
            var value = "AAAABBBCC";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charDictionary = textAnalytics.TenMostFrequentChar();

            //Assert
            Assert.AreEqual(3, charDictionary.Count);
            Assert.AreEqual(4, charDictionary['A']);
            Assert.AreEqual(3, charDictionary['B']);
            Assert.AreEqual(2, charDictionary['C']);
        }

    }
}
