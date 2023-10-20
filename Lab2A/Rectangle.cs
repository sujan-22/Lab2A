/*
  Class:  Rectangle.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Rectangle shape, providing methods to set its dimensions,
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
    public class Rectangle : TwoDimension
    {
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Set the dimensions of the Rectangle
        /// </summary>
        public override void SetData() {
            Console.Write("Enter the lenght: ");
            Length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            Width = double.Parse(Console.ReadLine());
        }

        public Rectangle()
        {
            Type = "Rectangle";
        }

        /// <summary>
        /// Calculate the area of the Rectangle
        /// </summary>
        /// <returns>The calculated area of the Rectangle.</returns>
        public override double CalculateArea()
        {
            return Math.Round((Length * Width), 3);
        }

        /// <summary>
        /// Calculate the volume of the Rectangle
        /// </summary>
        /// <returns>The calculated volume of the Rectangle.</returns>
        public override double CalculateVolume()
        {
            return 0; // 2D shapes don't have any volume
        }

        /// <summary>
        /// Format the Rectangle's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Rectangle.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15}";
        }
    
    }
}
