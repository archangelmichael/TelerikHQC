using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        private static Random generator = new Random();

        [TestMethod]
        public void TestCourseConstructor()
        {
            Course programming = new Course("Programming");
            Assert.IsInstanceOfType(programming,typeof(Course));
        }

        [TestMethod]
        public void TestCoursePropertyName()
        {
            Course course = new Course("english");
            Assert.AreEqual(course.CourseName, "english");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNameNullException()
        {
            Course nullCourse = new Course("");
        }

        [TestMethod]
        public void TestStudentConstructor()
        {
            Student student = new Student("student name", 10001);
            Assert.IsInstanceOfType(student, typeof(Student));
        }

        [TestMethod]
        public void TestStudentPropertyName()
        {
            Student student = new Student("student name", 10002);
            Assert.AreEqual(student.Name, "student name");
        }

        [TestMethod]
        public void TestStudentPropertyNumber()
        {
            Student student = new Student("student name", 10003);
            Assert.AreEqual(student.UniqueNumber, 10003);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentNameNullException()
        {
            Student student = new Student("", 1004);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentNumberOutOfBottomRangeBortherException()
        {
            Student student = new Student("student name", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentNumberOutOfTopRangeBorderException()
        {
            Student student = new Student("student name", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNumberAlreadyExistsException()
        {
            Student student = new Student("student name", 33333);
            Student anotherStudent = new Student("student name", 33333);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseCannotHaveMoreThan30Students()
        {
            Course testCourse = new Course("tester");
            Student currentStudent;
            for (int i = 0; i < 32; i++)
            {
                currentStudent = generateStudent();
                testCourse.AddStudent(currentStudent);
            }
        }

        [TestMethod]
        public void TestAddingNewStudentToCourse()
        {
            Course math = new Course("math");
            Student currentStudent = generateStudent();
            math.AddStudent(currentStudent);
            Assert.IsTrue(math.studentsInCourse.Contains(currentStudent));
        }

        [TestMethod]
        public void TestRemovingStudentFromCourse()
        {
            Course math = new Course("math");
            Student currentStudent = generateStudent();
            math.AddStudent(currentStudent);
            math.RemoveStudent(currentStudent);
            Assert.IsTrue(!math.studentsInCourse.Contains(currentStudent));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseCannotAddSameStudent()
        {
            Course randomCourse = new Course("random");
            Student currentStudent = generateStudent();
            randomCourse.AddStudent(currentStudent);
            randomCourse.AddStudent(currentStudent);
        }

        private static Student generateStudent()
        {
            string randomName = string.Empty;
            string randomNumber = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                randomName += (char)generator.Next(64, 122);
                randomNumber += generator.Next(1, 9);
            }

            int number = int.Parse(randomNumber);
            return new Student(randomName, number);
        }
    }
}
