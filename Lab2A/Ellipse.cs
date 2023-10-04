/*
  Class:  Ellipse.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This class represents a Ellipse shape, providing methods to set its dimensions,
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
    public class Ellipse : Shape
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellipse()
        {
            Type = "Ellipse";
        }

        /// <summary>
        /// Set the dimensions of the Ellipse
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the major axis: ");
            MajorAxis = double.Parse(Console.ReadLine());

            Console.Write("Enter the minor axis: ");
            MinorAxis = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calculate the area of the Ellipse
        /// </summary>
        /// <returns>The calculated area of the Ellipse.</returns>
        public override double CalculateArea()
        {
            return Math.Round((PI * MajorAxis * MinorAxis), 3);
        }

        /// <summary>
        /// Calculate the volume of the Ellipse
        /// </summary>
        /// <returns>The calculated volume of the Ellipse.</returns>
        public override double CalculateVolume()
        {
            return 0; // Ellipses are 2D shapes, no volume.
        }

        /// <summary>
        /// Format the Ellipse's information for display
        /// </summary>
        /// <returns>A formatted string containing information about the Ellipse.</returns>
        public override string ToString()
        {
            string dimensions = CalculateVolume() > 0 ? "3D" : "2D";

            return $"{Type,-15} {dimensions,-15} {CalculateArea(),-15}";
        }
    }
}
