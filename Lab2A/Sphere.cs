using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere()
        {
            Type = "Sphere";
        }

        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            Radius = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return 4 * PI * Math.Pow(Radius, 2);
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3) * PI * Math.Pow(Radius, 3);
        }

        public override string ToString()
        {
            return $"Type: {Type}, Radius: {Radius}, Surface Area: {CalculateArea()}, Volume: {CalculateVolume()}";
        }
    }
}
