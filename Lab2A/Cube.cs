using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Cube : Shape
    {
        public double SideLength { get; set; }

        public Cube()
        {
            Type = "Cube";
        }

        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            SideLength = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return Math.Round(6 * Math.Pow(SideLength, 2), 3);
        }

        public override double CalculateVolume()
        {
            return Math.Round(Math.Pow(SideLength, 3), 3);
        }

        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15} {CalculateVolume(),-15}";
        }
    }
}
