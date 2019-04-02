using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SoftUni_Course_Planning
{
    class SoftUniCoursePlanning
    {
        static List<string> GetCourseLessons()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ' };
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> courses = new List<string>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                courses.Add(inputArray[i]);
            }
            return courses;
        }

        static void Main()
        {
            List<string> softUniCourses = GetCourseLessons();

            bool isWorking = true;
            while (isWorking == true)
            {
                string input = Console.ReadLine();
                char[] separators = new char[] { ':' };
                string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandsArray[0] == "Add")
                {
                    // Check if such a course exists, and if it doesn't, add it
                    if (softUniCourses.Contains(commandsArray[1]) == false)
                    {
                        softUniCourses.Add(commandsArray[1]);
                    }
                }
                else if (commandsArray[0] == "Insert")
                {
                    if (softUniCourses.Contains(commandsArray[1]) == false)
                    {
                        softUniCourses.Insert(int.Parse(commandsArray[2]), commandsArray[1]);
                    }
                }
                else if (commandsArray[0] == "Remove")
                {
                    if (softUniCourses.Contains(commandsArray[1]) == true)
                    {
                        softUniCourses.Remove(commandsArray[1]);
                    }
                }
                else if (commandsArray[0] == "Swap")
                {
                    if (softUniCourses.Contains(commandsArray[1]) == true && softUniCourses.Contains(commandsArray[2]) == true)
                    {
                        int tempIndex1 = softUniCourses.IndexOf(commandsArray[1]);
                        string tempString1 = softUniCourses.ElementAt(tempIndex1);

                        int tempIndex2 = softUniCourses.IndexOf(commandsArray[2]);
                        string tempString2 = softUniCourses.ElementAt(tempIndex2);

                        int tempIndex1Exercise;
                        string tempString1Exercise;

                        int tempIndex2Exercise;
                        string tempString2Exercise;

                        if (softUniCourses[tempIndex1 + 1].Contains("Exercise:" + tempString1) == true)
                        {
                            tempIndex1Exercise = tempIndex1 + 1;
                            tempString1Exercise = softUniCourses.ElementAt(tempIndex1Exercise + 1);
                        }
                        if (softUniCourses[tempIndex2 + 1].Contains("Exercise:" + tempString2) == true)
                        {
                            tempIndex2Exercise = tempIndex2 + 1;
                            tempString2Exercise = softUniCourses.ElementAt(tempIndex2Exercise + 1);
                        }

                        softUniCourses.RemoveAt(tempIndex1);
                        softUniCourses.RemoveAt(tempIndex2);



                        softUniCourses.Insert(tempIndex1, tempString2);
                        softUniCourses.Insert(tempIndex2, tempString1);
                    }
                }
            }
        }
    }
}
