using System;
using System.Collections.Generic;
using System.Linq;

namespace ResultRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1,100);
            int AllStudents = rand_num;
            Console.WriteLine("The number of students in class is: "+ AllStudents);
            Console.WriteLine();

            int Pass = 0;
            int Average = 0;
            int Fail = 0;
            Console.WriteLine ("Below are the scores of all the students who took the exam");

            List<int> StudentsScores = new List<int>();
            for(int i = 0; i < AllStudents; i++) 
            {
                int Score = new Random().Next(1,100);
                Console.WriteLine(Score);

                if (Score >= 70)
                {
                    Pass = Pass + 1;
                }
                else if (Score >= 50 && Score <= 69)
                {
                    Average = Average + 1;
                }
                else 
                {
                    Fail = Fail + 1;
                }
                StudentsScores.Add(Score);
                    
            }
            Console.WriteLine("Total Number of students who took the exam"); 
            Console.WriteLine(AllStudents); 
            Console.WriteLine();

            Console.WriteLine("Total Number of students with scores ranging from 70 and above"); 
            Console.WriteLine(Pass);
            Console.WriteLine();

            Console.WriteLine("Total Number of students with scores ranging from 50 - 60"); 
            Console.WriteLine(Average);
            Console.WriteLine();

            Console.WriteLine("Total Number of students with scores below 50"); 
            Console.WriteLine(Fail);

        }
    }
}
            
