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
            Lengths obj = new Lengths(9, 7, 2, 3);
            double Line1 = obj.LengthOfLine();
            // For Line 2 Object
            Lengths objec = new Lengths(5,4,2,8);
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
            }
            Console.ReadLine();
        }
    }
}
