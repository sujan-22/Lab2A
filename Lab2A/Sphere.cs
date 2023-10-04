/*
  Class:  Sphere.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Sphere shape, providing methods to set its dimensions,
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
    public class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere()
        {
            Type = "Sphere";
        }

        /// <summary>
        /// Set the dimensions of the Sphere
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
            Radius = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate the area of the Sphere
        /// </summary>
        /// <returns>The calculated area of the Sphere.</returns>
        public override double CalculateArea()
        {
            return Math.Round(4 * PI * Math.Pow(Radius, 2), 3);
        }

        /// <summary>
        /// Calculate the volume of the Sphere
        /// </summary>
        /// <returns>The calculated volume of the Sphere.</returns>
        public override double CalculateVolume()
        {
            return Math.Round((4.0 / 3) * PI * Math.Pow(Radius, 3), 2);
        }

        /// <summary>
        /// Format the Sphere's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Sphere.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15} {CalculateVolume(),-15}";
        }
    }
}
