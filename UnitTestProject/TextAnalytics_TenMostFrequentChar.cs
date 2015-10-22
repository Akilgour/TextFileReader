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
            var charDictionary = textAnalytics.TenMostFrequentCharUsingCase();

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
            var charDictionary = textAnalytics.TenMostFrequentCharUsingCase();

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
            var charDictionary = textAnalytics.TenMostFrequentCharUsingCase();

            //Assert
            Assert.AreEqual(3, charDictionary.Count);
            Assert.AreEqual(4, charDictionary['A']);
            Assert.AreEqual(3, charDictionary['B']);
            Assert.AreEqual(2, charDictionary['C']);
        }

        [TestMethod]
        public void TestTextString()
        {
            //Arrange 
            var value = "The three did feed the deer The quick brown fox jumped over the lazy dog";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charDictionary = textAnalytics.TenMostFrequentCharUsingCase();

            //Assert
            Assert.AreEqual(10, charDictionary.Count);
            Assert.AreEqual(12, charDictionary['e'], "Error on e");
            Assert.AreEqual(6, charDictionary['d'], "Error on d");
            Assert.AreEqual(5, charDictionary['h'], "Error on h");
            Assert.AreEqual(4, charDictionary['r'], "Error on r");
            Assert.AreEqual(4, charDictionary['o'], "Error on o");
            Assert.AreEqual(2, charDictionary['u'], "Error on u");
            Assert.AreEqual(3, charDictionary['t'], "Error on t");
            Assert.AreEqual(2, charDictionary['u'], "Error on u");
            Assert.AreEqual(2, charDictionary['f'], "Error on f");
            Assert.AreEqual(2, charDictionary['T'], "Error on T");
        }


        [TestMethod]
        public void TestTextStringIgnoreCase()
        {
            //Arrange 
            var value = "Aa BBbb CCc";
            var textAnalytics = new TextAnalytics(value);

            //Act 
            var charDictionary = textAnalytics.TenMostFrequentCharIgnoreCase();

            //Assert
            Assert.AreEqual(3, charDictionary.Count);
            Assert.AreEqual(2, charDictionary['a']);
            Assert.AreEqual(4, charDictionary['b']);
            Assert.AreEqual(3, charDictionary['c']);
        }
    }
}
