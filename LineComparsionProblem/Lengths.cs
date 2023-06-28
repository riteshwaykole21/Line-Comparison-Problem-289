using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsionProblem
{
    public class Lengths
    {
        int X1,Y1,X2,Y2;
        public Lengths(int LenX1, int LenY1, int LenX2, int LenY2)
        {
            this.X1 = LenX1;           
            this.X2 = LenX2;
            this.Y1 = LenY1;
            this.Y2 = LenY2;   
        }
        public double LengthOfLine()
        {
            double length = Math.Sqrt(Math.Pow((X2 - X1 ), 2) + Math.Pow((Y2 - Y1 ), 2));
            return length;
        }
    }
}
