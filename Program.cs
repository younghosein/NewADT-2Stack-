using System.Runtime.InteropServices;

namespace NewADT_2Stack_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoAdt ta = new TwoAdt(20);
            ta.print();
            int l = ta.len();
            Console.WriteLine($"Count Is : {l}");
            Console.ResetColor();
            Console.WriteLine("\n------------------------------------------\n");

            ta.add(23);
            ta.add(45);
            ta.add(-11);
            ta.add(90);
            ta.add(-8);
            ta.add(-31);
            ta.add(6);
            ta.print();
            l = ta.len();
            Console.WriteLine($"Count Is : {l}");
            Console.ResetColor();
            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("Enter The Choice For Remove ( R Or L ) : ");
            string ch1 = Console.ReadLine();
            if (ch1 == "l" || ch1 == "l")
            {
                ta.remove(true);
            }
            else if (ch1 == "r" || ch1 == "R")
            {
                ta.remove(false);
            }
            ta.print();
            l = ta.len();
            Console.WriteLine($"Count Is : {l}");
            Console.ResetColor();
            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("Enter The Choice For Remove ( R Or L ) : ");
            ch1 = Console.ReadLine();
            if (ch1 == "l" || ch1 == "l")
            {
                ta.remove(true);
            }
            else if (ch1 == "r" || ch1 == "R")
            {
                ta.remove(false);
            }
            ta.print();
            l = ta.len();
            Console.WriteLine($"Count Is : {l}");
            Console.ResetColor();
            Console.WriteLine("\n------------------------------------------\n");


            Console.ReadKey();
        }
    }
}
