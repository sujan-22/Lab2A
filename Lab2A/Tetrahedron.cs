/*
  Class:  Tetrahedron.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Tetrahedron shape, providing methods to set its dimensions,
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
    public class Tetrahedron : Shape
    {
        public double EdgeLength { get; set; }

        /// <summary>
        /// Set the dimensions of the Tetrahedron
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the Edge lenght: ");
            EdgeLength = double.Parse(Console.ReadLine());

        }

        public Tetrahedron() {
            Type = "Tetrahedron";
        }

        /// <summary>
        /// Calculate the area of the Tetrahedron
        /// </summary>
        /// <returns>The calculated area of the Tetrahedron.</returns>
        public override double CalculateArea()
        {
            return Math.Round(Math.Sqrt(3) * Math.Pow(EdgeLength, 2), 3);
        }

        /// <summary>
        /// Calculate the volume of the Tetrahedron
        /// </summary>
        /// <returns>The calculated volume of the Tetrahedron.</returns>
        public override double CalculateVolume()
        {
            return Math.Round((Math.Pow(EdgeLength, 3))/(6 * Math.Sqrt(2)), 3);
        }

        /// <summary>
        /// Format the Tetrahedron's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Tetrahedron.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";
            return $"{Type, -15} {dimensions, -15} {CalculateArea(), -15} {CalculateVolume(), -15}";
        }
    }
}
