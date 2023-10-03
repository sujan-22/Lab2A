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
            Console.WriteLine("Enter the radius: ");
            Radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
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
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-30} {CalculateVolume(),-30}";
        }
    }
}
