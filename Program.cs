using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace D5A6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nos, scores;
            Console.WriteLine("Enter Number of Students");
            Nos=int.Parse(Console.ReadLine());
            String[][] students = new string[Nos][];
            for (int i=0; i<Nos; i++)
            {
                Console.WriteLine($"Enter Number of Scores of Student\t{i+1}");
                scores=int.Parse(Console.ReadLine());
                students[i] =new string[scores];
                for (int j=0; j<scores; j++)
                {
                    Console.WriteLine($"ENter scores for {j+1} subject " );
                    students[i][j]=Console.ReadLine();
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"student {i + 1}:");
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine(students[i][j]);
                }
            }
            Console.ReadKey();

        }
    }
}
