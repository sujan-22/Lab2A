/*
  Class:  Triangle.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Triangle shape, providing methods to set its dimensions,
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
    public class Triangle : Shape
    {
        private double Base { get; set; }
        private double Height { get; set; }

        public Triangle()
        {
            Type = "Triangle"; // Initialize the Type property
        }

        /// <summary>
        /// Set the dimensions of the Triangle
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the lenght of base: ");
            Base = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());

        }

        /// <summary>
        /// Calculate the area of the Triangle
        /// </summary>
        /// <returns>The calculated area of the Triangle.</returns>
        public override double CalculateArea()
        {
            return Math.Round(((Base * Height ) / 2), 3);
        }

        /// <summary>
        /// Calculate the volume of the Triangle
        /// </summary>
        /// <returns>The calculated volume of the Triangle.</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Format the Triangle's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Triangle.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type, -15} {dimensions, -15} {CalculateArea(), -15}";
        }
    }
}
