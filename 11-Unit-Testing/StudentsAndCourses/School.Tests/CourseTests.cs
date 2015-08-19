using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestCreatingValidCourseNotToThrow()
        {
            var testCourse = new Course("CSS");
        }

        [TestMethod]
        public void TestCourseToHaveExpectedName()
        {
            string courseName = "CSS";
            var testCourse = new Course(courseName);
            Assert.AreEqual(courseName, testCourse.Name, "Names are not equal");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidCourseNameShouldThrow()
        {
            var testCourse = new Course(null);
        }

        [TestMethod]
        public void TestAddingOneValidStudentNotToThrow()
        {
            var testStudent = new Student("Pesho", 10000);
            var testCourse = new Course("CSS");
            testCourse.AddStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingNullToCourseToThrow()
        {
            var testCourse = new Course("CSS");
            testCourse.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddingMoreThan30StudentsToCourseToThrow()
        {
            var testCourse = new Course("CSS");
            for (int i = 0; i < 31; i++)
            {
                string name = "Name #" + i.ToString();
                int number = 10000 + i;
                var testStudent = new Student(name, number);
                testCourse.AddStudent(testStudent);
            }
        }

        [TestMethod]
        public void TestCourseListToHaveSameLengthAsTheNUmberOfAddedStudents()
        {
            var expectedLength = 5;
            var testCourse = new Course("CSS");
            for (int i = 0; i < expectedLength; i++)
            {
                string name = "Name #" + i.ToString();
                int number = 10000 + i;
                var testStudent = new Student(name, number);
                testCourse.AddStudent(testStudent);
            }

            Assert.AreEqual(expectedLength, testCourse.Students.Count, "The count of the students in course are not euqal to the added number");
        }

        [TestMethod]
        public void TestCourseListToRemoveTheCorrectStudent()
        {
            int expectedStudentCount = 0;

            var testCourse = new Course("CSS");

            var testStudent = new Student("Pesho", 10000);

            testCourse.AddStudent(testStudent);

            testCourse.RemoveStudent(testStudent);

            Assert.IsFalse(testCourse.Students.Contains(testStudent), "Student must heve been removed.");
            Assert.AreEqual(expectedStudentCount, testCourse.Students.Count, "The count of the students in course is not euqal to expected.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullStudentFromCourseToThrow()
        {
            var testCourse = new Course("CSS");
            testCourse.RemoveStudent(null);
        }
    }
}
