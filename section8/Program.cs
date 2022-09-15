using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"D:\c#\basic codes\ConsoleApp1\section8data.txt";
            List<string> lines = new List<string>(File.ReadAllLines(myfile));
            lines.Sort();
            foreach (var line in lines)
            {
                Console.WriteLine(line);

            }
            FileStream inFile = new FileStream(@"D:\c#\basic codes\ConsoleApp1\section8data.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            bool found = false;

            Console.Write("Enter student name >> ");
            input = Console.ReadLine();
            try
            {

                record = reader.ReadLine();
                while (record != null)
                {


                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                        found = true;

                    }


                    record = reader.ReadLine();

                }
                if (!found)
                {
                    Console.WriteLine("student details not found");
                }

            }
            finally
            {

                inFile.Close();
            }
            Console.ReadLine();
        }
    }
}
