using NUnit.Framework;
using Utilities;

namespace ElektroFrameWork.Utilities.Tests
{
    [TestFixture]
    public class StringHelpers_test
    {
        [SetUp]
        public void TestInitialize()
        {
            
        }

        [TearDown]
        public void TestCleanUp()
        {
            
        }
        
        [Test]
        public void delete_spaces_from_start_and_end_from_word()
        {
            //Arrange
            var value = "   elektro  ";
            var expected = "elektro";
            
            //Actual
            var actual = StringHelpers.DeleteExtraSpaces(value);
            
            //Assert
            Assert.AreEqual(expected,actual);

        }
        
        [Test]
        public void delete_extra_spaces_from_word()
        {
            var value = "elektro    elektro  elektro  elektro        elektro";
            var expected = "elektro elektro elektro elektro elektro";
            var actual = StringHelpers.DeleteExtraSpaces(value);
            Assert.AreEqual(expected,actual);
        }
    }
}