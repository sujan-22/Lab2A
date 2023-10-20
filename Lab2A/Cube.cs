/*
  Class:  Cube.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Cube shape, providing methods to set its dimensions,
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
    public class Cube : ThreeDimension
    {
        public double SideLength { get; set; }

        public Cube()
        {
            Type = "Cube";
        }

        /// <summary>
        /// Set the dimensions of the Cube
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the side length: ");
            SideLength = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate the area of the Cube
        /// </summary>
        /// <returns>The calculated area of the Cube.</returns>
        public override double CalculateArea()
        {
            return Math.Round(6 * Math.Pow(SideLength, 2), 3);
        }

        /// <summary>
        /// Calculate the volume of the Cube
        /// </summary>
        /// <returns>The calculated volume of the Cube.</returns>
        public override double CalculateVolume()
        {
            return Math.Round(Math.Pow(SideLength, 3), 3);
        }

        /// <summary>
        /// Format the Cube's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Cube.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15} {CalculateVolume(),-15}";
        }
    }
}
