using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Box : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Box()
        {
            Type = "Box";
        }

        public override void SetData()
        {
            Console.Write("Enter the length: ");
            Length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return Math.Round((2 * (Length * Width + Length * Height + Width * Height)), 3);
        }

        public override double CalculateVolume()
        {
            return Math.Round((Length * Width * Height), 3);
        }

        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-10} {CalculateVolume(),-15}";
        }
    }
}
