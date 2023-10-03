using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder()
        {
            Type = "Cylinder";
        }

        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            Radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return 2 * PI * Radius * (Radius + Height);
        }

        public override double CalculateVolume()
        {
            return PI * Math.Pow(Radius, 2) * Height;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Radius: {Radius}, Height: {Height}, Surface Area: {CalculateArea()}, Volume: {CalculateVolume()}";
        }
    }
}
