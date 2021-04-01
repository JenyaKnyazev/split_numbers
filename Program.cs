using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static string split_number(int x, int y) {
            int x2, y2,div=2;
            string res=x+"/"+y+" = ";
            if (x > y) {
                res += x / y + " ";
                x = x % y;
            }
            x2 = x;
            y2 = y;
            while (x > 0) {
                int t = x;
                while (x * div < y) {
                    div++;
                }
                while (y % t != 0) {
                    t--;
                }
                if (y % t == 0 && t != 1 && y / t <= div ||x==1) {
                    res += "1/" + y/t;
                    x -= t;
                    x2 = x;
                    y2 = y;
                    if (x != 0)
                        res += " + ";
                    continue;
                }
                x += x2;
                y += y2;
            }
            return res;
        }
        static void run() {
            Console.WriteLine("Spliting numbers exit -1");
            while (true) {
                int x, y;
                Console.WriteLine("\nEnter first number");
                x = int.Parse(Console.ReadLine());
                if (x == -1)
                    break;
                Console.WriteLine("\nEnter second number");
                y = int.Parse(Console.ReadLine());
                if (y == -1)
                    break;
                Console.WriteLine(split_number(x, y));
            }
        }
        static void Main(string[] args)
        {
            run();
            Console.ReadLine();
        }
    }
}
