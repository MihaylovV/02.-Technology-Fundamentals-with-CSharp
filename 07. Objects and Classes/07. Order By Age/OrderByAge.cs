using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Order_By_Age
{
    class Person
    {
        // Fields
        string name = null;
        string id = null;
        int age = 0;

        // Constructor
        public Person(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        // Method
        public static List<Person> SortPeopleByAge(List<Person> listOfPeople)
        {
            listOfPeople.Sort((a, b) => a.age.CompareTo(b.age));
            return listOfPeople;
        }

        public static void PrintAllPeopleInList(List<Person> listOfPeople)
        {
            foreach (Person human in listOfPeople)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.", human.name, human.id, human.age);
            }
        }
    }

    class OrderByAge
    {
        static void Main()
        {
            List<Person> listOfPeople = GetUserInputIntoList();
            Person.SortPeopleByAge(listOfPeople);
            Person.PrintAllPeopleInList(listOfPeople);
        }

        static List<Person> GetUserInputIntoList()
        {
            List<Person> listOfPeople = new List<Person>();

            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    isRunning = false;
                    break;
                }
                else
                {
                    char[] separators = new char[] { ' ' };
                    string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    listOfPeople.Add(new Person(inputArray[0], inputArray[1], int.Parse(inputArray[2])));
                }
            }

            return listOfPeople;
        }
    }
}
