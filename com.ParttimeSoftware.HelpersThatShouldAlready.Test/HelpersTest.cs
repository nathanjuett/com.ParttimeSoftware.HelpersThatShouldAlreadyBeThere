using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.ParttimeSoftware.HelpersThatShouldAlreadyBeThere;
using System.Collections.Generic;

namespace com.ParttimeSoftware.HelpersThatShouldAlready.Test
{
    [TestClass]
    public class HelpersTest
    {
        [TestMethod]
        public void TestToString()
        {
            TestClass testclass = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            testclass.Class = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            string actual = testclass.ToString(',');
            Assert.AreEqual("5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"", actual);
        }
        [TestMethod]
        public void TestListToString()
        {
            TestClass testclass = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            testclass.Class = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            List<TestClass> lst = new List<TestClass>();
            for (int i = 0; i < 2; i++)
            {
                lst.Add(testclass);
            }
            string actual = lst.ToString(',');
            Assert.AreEqual("5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\r\n5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\r\n", actual);
        }
        [TestMethod]
        public void TestDictionaryToString()
        {
            TestClass testclass = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            testclass.Class = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            Dictionary<int, TestClass> lst = new Dictionary<int, TestClass>();
            for (int i = 0; i < 2; i++)
            {
                lst.Add(i, testclass);
            }
            string actual = lst.ToString(',');
            Assert.AreEqual("0,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\"\r\n1,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\"\r\n", actual);
        }
        [TestMethod]
        public void TestArrayToString()
        {
            TestClass testclass = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            testclass.Class = new TestClass() { ID = 5, Decimal = 3.3M, Float = 3.23423F, String = "blah, \"asdff\"" };
            List<TestClass> lst = new List<TestClass>();
            for (int i = 0; i < 2; i++)
            {
                lst.Add(testclass);
            }
            string actual = lst.ToArray().ToString(',');
            Assert.AreEqual("5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\r\n5,\"blah, \"\"asdff\"\"\",3.3,3.23423,\"5,\"blah, \"\"asdff\"\"\",3.3,3.23423\"\r\n", actual);

        }
    }
}
