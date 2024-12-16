using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewADT_2Stack_
{
    internal class TwoAdt
    {
        public int[] twoStack;
        public int top1;
        public int top2;
        public int max;
        //int count = 0;

        public TwoAdt(int size)
        {
            twoStack = new int[size];
            max = size;
            top1 = -1;
            top2 = max;
        }

        public bool isEmpty(bool ch)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (ch)
            {
                return (top1 == -1);
            }
            else
            {
                return (top2 == max);
            }
        }

        public bool isFull()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return (top1 == top2 - 1 || top2 == top1 + 1);
        }

        public void add(int d)
        {
            if (isFull())
            {
                Console.WriteLine("TwoStack Is Full !");
                return;
            }
            else
            {
                if (d > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    twoStack[++top1] = d;
                    Console.WriteLine($"{d} Is Inserted At index[{top1}]");
                    //count++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    twoStack[--top2] = d;
                    Console.WriteLine($"{d} Is Inserted At Index[{top2}]");
                    //count++;
                }
            }
            Console.ResetColor();
        }

        public void remove(bool ch)
        {
            if (isEmpty(ch))
            {
                return;
            }
            else
            {
                if (ch)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{twoStack[top1]} Is Deleted From Index[{top1}] -> (S1)");
                    top1--;
                    //count--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{twoStack[top2]} Is Deleted From Index[{top2}] -> (S2)");
                    top2++;
                    //count--;
                }
            }
            Console.ResetColor();
        }

        public int len()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return ((top1 + 1) + (max - top2));
        }

        #region Extra

        public void print()
        {
            Console.WriteLine();
            if (!isEmpty(true))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("S1 is -> ");
                for (int i = 0; i <= top1; i++)
                {
                    Console.ResetColor();
                    Console.Write($"Index[{i}] -> ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{twoStack[i]} . ");
                }
            }
            else
            {
                Console.WriteLine("S1 Is Empty!");
            }
            if (!isEmpty(false))
            {
                for (int i = top2; i <= max - 1; i++)
                {
                    Console.ResetColor();
                    Console.Write($"Index[{i}] -> ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{twoStack[i]} . ");
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" <- S2 Is");
            }
            else
            {
                Console.WriteLine("S2 Is Empty!");
            }
        }

        #endregion
    }
}
