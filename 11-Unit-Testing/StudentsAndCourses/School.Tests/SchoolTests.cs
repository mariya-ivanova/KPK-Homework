using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void TestCreatingValidSchoolNotToThrow()
        {
            var testSchool = new School("Telerik Academy");
        }

        [TestMethod]
        public void TestCourseToHaveExpectedName()
        {
            string schoolName = "Telerik Academy";
            var testSchool = new School(schoolName);
            Assert.AreEqual(schoolName, testSchool.Name, "Names are not equal");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidCourseNameShouldThrow()
        {
            var testSchool = new School(null);
        }

        [TestMethod]
        public void TestRegistringAValidStudentNotToThrow()
        {
            var testStudent = new Student("Pesho", 10000);
            var testSchool = new School("Telerik Academy");
            testSchool.AddStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestResgistringNullToSchoolToThrow()
        {
            var testSchool = new School("Telerik Academy");
            testSchool.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestResgistringStudentsWithSameNumberToSchoolToThrow()
        {
            var testSchool = new School("Telerik Academy");
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10000);
            testSchool.AddStudent(pesho);
            testSchool.AddStudent(gosho);
        }

        [TestMethod]
        public void TestStudentsCountInSchoolToEqualTheRegistredNumberOfStudents()
        {
            var expectedLength = 5;
            var testSchool = new School("Telerik Academy");
            for (int i = 0; i < expectedLength; i++)
            {
                string name = "Name #" + i.ToString();
                int number = 10000 + i;
                var testStudent = new Student(name, number);
                testSchool.AddStudent(testStudent);
            }

            Assert.AreEqual(expectedLength, testSchool.StudentListInSchool.Count, "The count of the students in the school is not euqal to the added number");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingNullAsCourseToSchoolToThrow()
        {
            var testSchool = new School("Telerik Academy");
            testSchool.AddCourse(null);
        }

        [TestMethod]
        public void TestCourseCountInSchoolToEqualTheAddedNumberOfCourses()
        {
            var expectedLength = 5;
            var testSchool = new School("Telerik Academy");
            for (int i = 0; i < expectedLength; i++)
            {
                string name = "Course #" + i.ToString();
                var testCourse = new Course(name);
                testSchool.AddCourse(testCourse);
            }

            Assert.AreEqual(expectedLength, testSchool.CourseListInSchool.Count, "The count of the courses in the school is not euqal to the added number");
        }
    }
}
