﻿using System;
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
            Console.WriteLine("Enter the length: ");
            Length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            Width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
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
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-30} {CalculateVolume(),-30}";
        }
    }
}
