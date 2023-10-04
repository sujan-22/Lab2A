using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Triangle : Shape
    {
        private double Base { get; set; }
        private double Height { get; set; }

        public Triangle()
        {
            Type = "Triangle"; // Initialize the Type property
        }

        public override void SetData()
        {
            Console.Write("Enter the lenght of base: ");
            Base = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());

        }

        public override double CalculateArea()
        {
            return Math.Round(((Base * Height ) / 2), 3);
        }

        public override double CalculateVolume()
        {
            return 0;
        }

        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type, -15} {dimensions, -15} {CalculateArea(), -15}";
        }
    }
}
