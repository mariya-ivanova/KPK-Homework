using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructorTestName()
        {
            string name = "Pesho Petrov";
            int classNumber = 12345;
            Student student = new Student(name, classNumber);
            Assert.AreEqual(student.Name, "Pesho Petrov");
        }

        [TestMethod]
        public void StudentConstructorTestUniqueNumber()
        {
            string name = "Pesho Petrov";
            int classNumber = 12345;
            Student student = new Student(name, classNumber);
            Assert.AreEqual(student.ClassNumber, 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            int classNumber = 12345;
            Student student = new Student(name, classNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            int classNumber = 12345;
            Student student = new Student(name, classNumber);
        }

        [TestMethod]
        public void UniqueNumberTestStartValue()
        {
            string name = "Pesho Petrov";
            int classNumber = 10000;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumberTestEndValue()
        {
            string name = "Pesho Petrov";
            int classNumber = 99999;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestStartValueMinusOne()
        {
            string name = "Pesho Petrov";
            int classNumber = 9999;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlusOne()
        {
            string name = "Pesho Petrov";
            int classNumber = 100000;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlus10000()
        {
            string name = "Pesho Petrov";
            int classNumber = 109999;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestZero()
        {
            string name = "Pesho Petrov";
            int classNumber = 0;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestIntMaxValue()
        {
            string name = "Pesho Petrov";
            int classNumber = int.MaxValue;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestNegativeValue()
        {
            string name = "Pesho Petrov";
            int classNumber = -55555;
            Student student = new Student(name, classNumber);
            Assert.IsTrue(classNumber >= 10000 && classNumber <= 99999);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string name = "Pesho Petrov";
            int classNumber = 12345;
            Student student = new Student(name, classNumber);
            string expected = "Student Pesho Petrov, ID 12345; ";
            string actual;
            actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
