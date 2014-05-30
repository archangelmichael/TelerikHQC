namespace Methods
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstStudentBirthDate = this.GetBirthDate(this);
            DateTime secondStudentBirthDate = this.GetBirthDate(other);
            return firstStudentBirthDate > secondStudentBirthDate;
        }

        /// <summary>
        /// Gets the birth date, if there is additional information provided for the student
        /// </summary>
        /// <param name="student">a student object</param>
        /// <returns>birthdate of student</returns>
        /// <exception cref="ArgumentNullException()"></exception>
        private DateTime GetBirthDate(Student student)
        {
            if (student.OtherInfo == null)
            {
                string studentName = student.FirstName + " " + student.LastName;
                throw new ArgumentNullException(string.Format("There is no additional information for {0}!", studentName));
            }

            string expression = @"\b\d{1,2}[/.|:|/]\d{1,2}[/.|:|/]\d{2,4}\b";
            //// regular expression to find dates from in a string

            string studentInfo = student.OtherInfo;
            Match matchDate = Regex.Match(studentInfo, expression);
            DateTime studentBirthdate = DateTime.Parse(matchDate.Value);

            return studentBirthdate;
        }
    }
}
