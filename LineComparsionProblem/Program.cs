using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsionProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparsion Problem");
            Lengths obj = new Lengths(9, 7, 2, 3);
            obj.LengthOfLine();
            Console.ReadLine();
        }
    }
}
