using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2A
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            bool myBool = false;
            while (!myBool)
            {
                string menu =
$@"
--------------------------------------------------------------------
 Sujan's Geometry
--------------------------------------------------------------------
 1) Rectangle       2) Square       3) Box  
 4) Cube            5) Ellipse      6) Circle           
 7) Cylinder        8) Sphere       9) Triangle   
10) Tetrahedron

 0) List all shapes and exit            ( {shapes.Count} shapes entered so far! )
--------------------------------------------------------------------
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
                        shapes.Add(rectangle);
                        break;

                    case 2:
                        Square square = new Square();
                        square.SetData();
                        shapes.Add(square);
                        break;

                    case 3:
                        Box box = new Box();
                        box.SetData();
                        shapes.Add(box);
                        break;

                    case 4:
                        Cube cube = new Cube();
                        cube.SetData();
                        shapes.Add(cube);
                        break;

                    case 5:
                        Ellipse ellipse = new Ellipse();
                        ellipse.SetData();
                        shapes.Add(ellipse);
                        break;

                    case 6:
                        Circle circle = new Circle();
                        circle.SetData();
                        shapes.Add(circle);
                        break;

                    case 7:
                        Cylinder cylinder = new Cylinder();
                        cylinder.SetData();
                        shapes.Add(cylinder);
                        break;

                    case 8:
                        Sphere sphere = new Sphere();
                        sphere.SetData();
                        shapes.Add(sphere);
                        break;

                    case 9:
                        Triangle triangle = new Triangle();
                        triangle.SetData();
                        shapes.Add(triangle);
                        break;

                    case 10:
                        Tetrahedron tetrahedron = new Tetrahedron();
                        tetrahedron.SetData();
                        shapes.Add(tetrahedron);
                        break;
                    case 0:
                        Console.WriteLine(" ");
                        Console.WriteLine("Displaying table of all instantiated shapes...");
                        Console.WriteLine(" ");
                        // Define the column headers
                        Console.WriteLine(new string('~', 60));
                        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Type", "Dimensions", "Area", "Volume");
                        Console.WriteLine(new string('~', 60));

                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape);
                            Console.WriteLine(new string('-', 60));
                        }

                        Console.WriteLine("Press any key to exit..");
                        Console.ReadKey();

                        myBool = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

            }

        }
    }
}
