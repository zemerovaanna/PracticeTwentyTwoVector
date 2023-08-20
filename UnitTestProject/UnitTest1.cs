using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVectorName1()
        {
            string name = "aa";
            string expected = "Вектор может называться только одним символом.";
            string actual = Class1.CheckVectorName(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckVectorName2()
        {
            string name = "1";
            string expected = "Вектор может называться только одной маленькой буквой.";
            string actual = Class1.CheckVectorName(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckVectorName3()
        {
            string name = "a";
            string expected = "";
            string actual = Class1.CheckVectorName(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckVectorNameTwo1()
        {
            string name = "a";
            string filename = "Vectors.txt";
            string expected = "Такой вектор уже существует в файле.";
            string actual = Class1.CheckVectorNameTwo(name, filename);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckVectorNameTwo2()
        {
            string name = "p";
            string filename = "Vectors.txt";
            string expected = "";
            string actual = Class1.CheckVectorNameTwo(name, filename);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckFileName1 ()
        {
            string filename = "abcdefghigklmnopqrstu";
            string expected = "Имя файла не может быть больше 20 символов.";
            string actual = Class1.CheckFileName(filename);
            Assert.AreEqual(expected, actual);
        }

        public void CheckFileName2 ()
        {
            string filename = "12345678abc";
            string expected = "В имени файла могут быть только буквы.";
            string actual = Class1.CheckFileName(filename);
            Assert.AreEqual(expected, actual);
        }

        public void CheckFileName3 ()
        {
            string filename = "12345678abc";
            string expected = "MyVectr";
            string actual = Class1.CheckFileName(filename);
            Assert.AreEqual(expected, actual);
        }
    }
}