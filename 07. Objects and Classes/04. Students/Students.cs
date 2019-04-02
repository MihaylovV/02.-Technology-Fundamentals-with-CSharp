using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    class Student
    {
        string firstName = null;
        string lastName = null;
        float grade = 0;

        public Student(string firstName, string lastName, float grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public void PrintStudentInfo(Student studentName)
        {
            Console.WriteLine("{0} {1}: {2:F2}", this.firstName, this.lastName, this.grade);
        }
    }

    class Students
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char[] separators = new char[] { ' ' };
                string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                listOfStudents.Add(new Student(commandsArray[0], commandsArray[1], float.Parse(commandsArray[2])));
            }

            listOfStudents.Sort((p, q) => q.Grade.CompareTo(p.Grade));

            foreach (Student person in listOfStudents)
            {
                person.PrintStudentInfo(person);
            }
        }
    }
}
