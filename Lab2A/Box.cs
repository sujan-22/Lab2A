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
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        public override double CalculateVolume()
        {
            return Length * Width * Height;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Length: {Length}, Width: {Width}, Height: {Height}, Surface Area: {CalculateArea()}, Volume: {CalculateVolume()}";
        }
    }
}
