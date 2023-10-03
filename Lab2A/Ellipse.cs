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

        public override void SetData()
        {
            Console.Write("Enter the major axis: ");
            MajorAxis = double.Parse(Console.ReadLine());

            Console.Write("Enter the minor axis: ");
            MinorAxis = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return PI * MajorAxis * MinorAxis;
        }

        public override double CalculateVolume()
        {
            return 0; // Ellipses are 2D shapes, no volume.
        }

        public override string ToString()
        {
            return $"Type: {Type}, Major Axis: {MajorAxis}, Minor Axis: {MinorAxis}, Area: {CalculateArea()}";
        }
    }
}
