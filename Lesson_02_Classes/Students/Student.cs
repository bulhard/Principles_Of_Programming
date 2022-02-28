/*
 . Define a class Student, which contains the following information about 
students: full name, course, subject, university, e-mail and phone number.

 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_02_Classes.Students
{
    public class Student
    {
        public static int NumberOfStudents = 0;
        private string fullName;

        public Student() : this("John Doe")
        {

        }

        public Student(string fullName)
        {
            NumberOfStudents++;

            FullName = fullName;
            Course = 1;
            Subject = null;
        }

        public string FullName { 
            get { return fullName; }
            set 
            {
                if (value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                fullName = value; 
            } 
        }

        public int Course { get; set; }

        public string Subject { get; set; }

        public string University { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{FullName} Course: {Course} Subject: {Subject} ...";
        }
    }
}
