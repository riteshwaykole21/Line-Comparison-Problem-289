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
            // For Line 1 Object
            Lengths obj = new Lengths(1,4,2,8);
            double Line1 = obj.LengthOfLine();
            // For Line 2 Object
            Lengths objec = new Lengths(5,9,9,8);
            double Line2 = objec.LengthOfLine();
            Console.WriteLine("Length Of Second Line = " + Line2);
            // Equal Method Given Boolen Condition
            if(Line1.Equals(Line2))
            {
                Console.WriteLine("Both Lines Are Equal");
            }
            else
            {
                Console.WriteLine("No Both Lines Are UnEqual");
                // To Check Which Line is Greater By Compare To Method
                if(Line1.CompareTo(Line2) > 0)
                {
                    Console.WriteLine("Line 1 Greater To Line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 Is Less Than 2");
                }
            }

              Console.ReadLine();
        }
    }
}
