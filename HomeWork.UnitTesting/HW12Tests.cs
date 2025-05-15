using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW12Tests
    {
        [TestMethod]
        public void getSubArrByStartingCh_ValidValues_ReturnsAllSubArr()
        {

            // Arrange
            HW12 myCode = new HW12();
            string s = "Java is a good language";
            char ch = 'a';
            string[] actual;
            string[] expected = { "ava is a good language",
                                "a is a good language",
                                "a good language",
                                "anguage"
                                , "age"            };

            // Act
            actual = myCode.getSubArrByStartingCh(s, ch);

            // Assert
            if(actual == null)
                Assert.Fail("Should not return null");
            
            Assert.AreEqual(expected.Length, actual.Length , "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in index #" + i);
            
        }

        [TestMethod]
        public void getSubArrByStartingCh_sIsAAAAAchIsA_ReturnsAllSubArr()
        {

            // Arrange
            HW12 myCode = new HW12();
            string s = "AAAAA";
            char ch = 'A';
            string[] actual;
            string[] expected = { "AAAAA" , "AAAA" , "AAA" , "AA"  , "A"};

            // Act
            actual = myCode.getSubArrByStartingCh(s, ch);

            // Assert
            if (actual == null)
                Assert.Fail("Should not return null");

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in index #" + i);

        }

        [TestMethod]
        public void getSubArrByStartingCh_sIsAAAAAchIsB_ReturnsEmptyArr()
        {

            // Arrange
            HW12 myCode = new HW12();
            string s = "AAAAA";
            char ch = 'B';
            string[] actual;
            string[] expected = { };

            // Act
            actual = myCode.getSubArrByStartingCh(s, ch);

            // Assert
            if (actual == null)
                Assert.Fail("Should not return null");

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");


        }


        [TestMethod]
        [DataRow("Java is a good language" , 'a' ,new string[] { "ava is a good language",
                                "a is a good language",
                                "a good language",
                                "anguage"
                                , "age"            } , DisplayName = "getSubArrByStartingCh_ValidValues_ReturnsAllSubArr")]
        [DataRow("AAAAA", 'A', new string[] { "AAAAA", "AAAA", "AAA", "AA", "A" }, DisplayName = "getSubArrByStartingCh_sIsAAAAAchIsA_ReturnsAllSubArr")]
        [DataRow("AAAAA", 'B', new string[] { }, DisplayName = "getSubArrByStartingCh_sIsAAAAAchIsB_ReturnsEmptyArr")]
        [DataRow("", 'B', new string[] { }, DisplayName = "getSubArrByStartingCh_sIsEmptyArr_ReturnsEmptyArr")]
        [DataRow(null, 'B', null, DisplayName = "getSubArrByStartingCh_sIsNull_ReturnsNull")]
        public void getSubArrByStartingCh(string s , char ch, string[] expected)
        {

            // Arrange
            HW12 myCode = new HW12();
            string[] actual;

            // Act
            actual = myCode.getSubArrByStartingCh(s, ch);

            // Assert
            if(expected == null && actual == null)
            {
                Assert.IsTrue(true);
                return;
            }

            if (expected == null && actual != null)
                Assert.Fail("Should return null");


            if (expected != null && actual == null)
                Assert.Fail("Should not return null");

            Assert.AreEqual(expected.Length, actual.Length, "Bug in array length");

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Bug in index #" + i);


        }
    }
}
