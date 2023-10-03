using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Type = "Circle";
        }

        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            Radius = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override double CalculateVolume()
        {
            return 0; // Circles are 2D shapes, no volume.
        }

        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-10}";
        }
    }

}
