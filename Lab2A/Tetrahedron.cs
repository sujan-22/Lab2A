using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Tetrahedron : Shape
    {
        public double EdgeLength { get; set; }

        public override void SetData()
        {
            Console.WriteLine("Enter the Edge lenght: ");
            EdgeLength = double.Parse(Console.ReadLine());

        }

        public Tetrahedron() {
            Type = "Tetrahedron";
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Math.Pow(EdgeLength, 2);
        }

        public override double CalculateVolume()
        {
            return (Math.Pow(EdgeLength, 3))/(6 * Math.Sqrt(2));
        }

        public override string ToString()
        {
            return $"Type: {Type}, EdgeLength: {EdgeLength},  Area: {CalculateArea()}, Volume: {CalculateVolume()} ";
        }
    }
}
