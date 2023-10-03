using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override void SetData() {
            Console.WriteLine("Enter the lenght: ");
            Length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            Width = double.Parse(Console.ReadLine());
        }

        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculateVolume()
        {
            return 0; // 2D shapes don't have any volume
        }

        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-30}";
        }
    
    }
}
