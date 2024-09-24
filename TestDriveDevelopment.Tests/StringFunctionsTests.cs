using NUnit.Framework;
using System;

namespace TestDriveDevelopment.Tests
{
    [TestFixture]
    public class StringFunctionsTests
    {
        [Test]
        public void FindShortestWord_Sentence_ReturnsShortestWord()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "This is a simple test";
            string expected = "a";

            string result = processor.FindShortestWord(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CountWords_Sentence_ReturnsWordCount()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "How many words are here";
            int expected = 5;

            int result = processor.CountWords(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CountCharacters_Sentence_ReturnsCharacterCount()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "Count characters";
            int expected = 16;

            int result = processor.CountCharacters(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FindNinthCharacter_Sentence_ReturnsNinthCharacter()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "Find ninth character";
            char expected = 't';

            char result = processor.FindNinthCharacter(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CountDigits_Sentence_ReturnsDigitCount()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "There are 123 digits in 2021";
            int expected = 7;

            int result = processor.CountDigits(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxConsecutiveDigits_Sentence_ReturnsMaxConsecutiveDigits()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "In 1001234, the max digits are consecutive";
            int expected = 7;

            int result = processor.MaxConsecutiveDigits(sentence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CountAmCombinations_Sentence_ReturnsAmCombinationCount()
        {
            StringProcessor processor = new StringProcessor();
            string sentence = "Here are many examples of 'ам' combinations.";
            int expected = 1;

            int result = processor.CountAmCombinations(sentence);

            Assert.AreEqual(expected, result);
        }
    }
}
