using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    class Program
    {

        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 2; // readonly in constructor
        }
        static void Main(string[] args)
        {
            //ConstantVariable = 2; cannot assign value
            //ReadOnlyVariable = 2; can assign value in constructor

            //Console.WriteLine(ConstantNumber);
            //Console.WriteLine(ReadOnlyNumber);
            //Agency agency = null;
            //Console.WriteLine(agency?.Name);
            //Console.ReadLine();

            using (FileStream fs1 = new FileStream(@"c:\temp\tempAgency.txt",FileMode.Open) )
            {
                // do something
            }
        }
    }
}
