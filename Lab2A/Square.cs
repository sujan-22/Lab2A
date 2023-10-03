using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public Square()
        {
            Type = "Square";
        }

        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            SideLength = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public override double CalculateVolume()
        {
            return 0; // Squares are 2D shapes, no volume.
        }

        public override string ToString()
        {
            return $"Type: {Type}, Side Length: {SideLength}, Area: {CalculateArea()}";
        }
    }
}
