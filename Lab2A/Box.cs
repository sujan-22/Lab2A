/*
  Class:  Box.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Box shape, providing methods to set its dimensions,
           calculate its surface area and volume, and format the information for display.

  Authorship statement: I, Sujan Rokad, 000882948 certify that this material is my origianl work. No other person's work has been used                     without due acknowledgement.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Box : ThreeDimension
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Box()
        {
            Type = "Box";
        }

        /// <summary>
        /// Set the dimensions of the Box
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the length: ");
            Length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate the area of the Box
        /// </summary>
        /// <returns>The calculated area of the Box.</returns>
        public override double CalculateArea()
        {
            return Math.Round((2 * (Length * Width + Length * Height + Width * Height)), 3);
        }

        /// <summary>
        /// Calculate the volume of the Box
        /// </summary>
        /// <returns>The calculated volume of the Box.</returns>
        public override double CalculateVolume()
        {
            return Math.Round((Length * Width * Height), 3);
        }

        /// <summary>
        /// Format the Box's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Box.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15} {CalculateVolume(),-15}";
        }
    }
}
