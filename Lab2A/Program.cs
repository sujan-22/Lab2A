using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                string menu =
$@"
 \u001b[32mSujan's Geometry\u001b[0m
-----------------------------------------
 1) Rectangle             2) Square      
 3) Box                   4) Cube
 5) Ellipse               6) Circle
 7) Cylinder              8) Sphere
 9) Triangle             10) Tetrahedron

 0) List all shapes and exit               (0 shapes entered so far)
-----------------------------------------
Enter your choice: ";

                Console.Write(menu);

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice");
                        continue;
                }

                switch (choice)
                {
                    case 1:
                        Rectangle rectangle = new Rectangle();
                        rectangle.SetData();
                        rectangle.CalculateArea();
                        rectangle.CalculateVolume();
                        shapes.Add(rectangle);
                        break;

                    case 2:
                        Square square = new Square();
                        shapes.Add(square);
                        break;

                    case 3:
                        Box box = new Box();
                        shapes.Add(box);
                        break;

                    case 4:
                        Cube cube = new Cube();
                        shapes.Add(cube);
                        break;

                    case 5:
                        Ellipse ellipse = new Ellipse();
                        shapes.Add(ellipse);
                        break;

                    case 6:
                        Circle circle = new Circle();
                        shapes.Add(circle);
                        break;

                    case 7:
                        Cylinder cylinder = new Cylinder();
                        shapes.Add(cylinder);
                        break;

                    case 8:
                        Sphere sphere = new Sphere();
                        shapes.Add(sphere);
                        break;

                    case 9:
                        Triangle triangle = new Triangle();
                        shapes.Add(triangle);
                        break;

                    case 10:
                        Tetrahedron tetrahedron = new Tetrahedron();
                        shapes.Add(tetrahedron);
                        break;
                    case 0:
                        Console.WriteLine($"Exiting\n({shapes.Count} shapes entered so far)");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
                Console.WriteLine("Shapes:");
                foreach (var shape in shapes)
                {
                    Console.WriteLine(shape);
                }


            }

            
        
        }
    }
}
