namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public static IList<int> studentNumbers = new List<int>();
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
            studentNumbers.Add(uniqueNumber);
            School.students.Add(this);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student must have a valid name!");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (10000 > value || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Student number should be between 10000 and 99999!");
                }

                if (studentNumbers.Contains(value))
                {
                    throw new ArgumentException("A student with this number already exists!");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
