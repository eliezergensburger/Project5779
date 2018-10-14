using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammmm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stam;
            int choice = -1;
            do
            {
                Console.WriteLine(@"Please enter:
                                        1:  targil1 seif 1
                                        2:  targil1 seif 2
                                        0:  QUIT");
                stam = Int32.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        targil1_1();
                        break;
                    case 2:
                        targil1_2();
                        break;
                    case 0:
                        stam = false;
                        break;
                    default:
                        Console.WriteLine("enter 1 or 2 -- 0 to QUIT");
                        break;
                }
            }
            while (stam);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void targil1_2()
        {
            throw new NotImplementedException();
        }

        private static void targil1_1()
        {
            Random r = new Random();
            int[] maarach = new int[100];
            for (int i = 0; i < maarach.Length; i++)
            {
                maarach[i] = r.Next(0, 1001);
            }
            printVec(maarach);
            int mispar;
            Console.WriteLine("guess a number : ");
            try
            {
                mispar = Int32.Parse(Console.ReadLine());
                foreach (int item in maarach)
                {
                    if (item == mispar)
                    {
                        Console.WriteLine("kol haQavod");
                        return;
                    }
                }
                Console.WriteLine("too bad!!");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
         }

        private static void printVec(int[] maarach)
        {
            for (int i = 0; i < maarach.Length; i++)
            {
                Console.WriteLine("m[{0}] = {1}", i, maarach[i]);
            }
        }
    }
}
