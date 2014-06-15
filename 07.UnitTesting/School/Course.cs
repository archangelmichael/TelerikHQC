namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public IList<Student> studentsInCourse = new List<Student>();
        private string courseName;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            School.courses.Add(this);
        }

        public string CourseName
        {
            get 
            {
                return this.courseName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter course name!");
                }

                this.courseName = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.studentsInCourse.Contains(student))
            {
                throw new ArgumentException(string.Format("Student with number {0} is already attending course in {1}!", 
                    student.UniqueNumber, this.CourseName));
            }

            if (this.studentsInCourse.Count >= 30)
            {
                throw new ArgumentException("Course is already full!");
            }

            this.studentsInCourse.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.studentsInCourse.Contains(student))
            {
                this.studentsInCourse.Remove(student);
            }
        }
    }
}
