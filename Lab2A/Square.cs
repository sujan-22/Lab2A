/*
  Class:  Square.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Square shape, providing methods to set its dimensions,
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
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public Square()
        {
            Type = "Square";
        }

        /// <summary>
        /// Set the dimensions of the Square
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            SideLength = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate the area of the Square
        /// </summary>
        /// <returns>The calculated area of the Square.</returns>
        public override double CalculateArea()
        {
            return Math.Round(Math.Pow(SideLength, 2), 3);
        }

        /// <summary>
        /// Calculate the volume of the Square
        /// </summary>
        /// <returns>The calculated volume of the Square.</returns>
        public override double CalculateVolume()
        {
            return 0; // Squares are 2D shapes, no volume.
        }

        /// <summary>
        /// Format the Square's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Square.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15}";
        }
    }
}
