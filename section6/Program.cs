using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mainproject1
{
  public  class Program
    {
        static void Main(string[] args)
        {
            string file = @"D:\c#\basic codes\ConsoleApp1\studentsdata.txt";
            if (File.Exists(file))
            {
                string r = File.ReadAllText(file);
                Console.WriteLine(r);
                Console.ReadLine();


            }
        }
    }
}
