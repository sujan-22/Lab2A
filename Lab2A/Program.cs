/*
  Class:  Program.cs
  Author: Sujan Rokad
  Date:   October 4, 2023

  Purpose: This program allows the user to create and manage instances of various geometric shapes,
           calculate their areas and volumes, and display the information in a neat table.

  Authorship statement: I, Sujan Rokad, 000882948 certify that this material is my origianl work. No other person's work has been used                     without due acknowledgement.
*/

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
            // Create a list to store shapes
            List<Shape> shapes = new List<Shape>();

            // Create a boolean flag to control the while loop
            bool myBool = false;

            // Main menu loop
            while (!myBool)
            {

                // Display the main menu to the user
                string menu =
$@"
|--------------------------------------------------------------------|
|                         Sujan's Geometry                           |
|--------------------------------------------------------------------|
| 1) Rectangle  |   2) Square   |   3) Box       |  10) Tetrahedron  |
| 4) Cube       |   5) Ellipse  |   6) Circle                        |
| 7) Cylinder   |   8) Sphere   |   9) Triangle                      |
|                                                                    |
| 0) List all shapes and exit            ( {shapes.Count} shapes entered so far! )|
|--------------------------------------------------------------------|
Enter your choice: ";

                // Prints the menu
                Console.Write(menu);

                int choice;

                // Get the user's choice
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice");
                        continue;
                }

                switch (choice)
                {
                    case 1:
                        // Create a Rectangle object, set its data, and add it to the list
                        Rectangle rectangle = new Rectangle();
                        rectangle.SetData();
                        shapes.Add(rectangle);
                        break;

                    case 2:
                        // Create a Square object, set its data, and add it to the list
                        Square square = new Square();
                        square.SetData();
                        shapes.Add(square);
                        break;

                    case 3:
                        // Create a Box object, set its data, and add it to the list
                        Box box = new Box();
                        box.SetData();
                        shapes.Add(box);
                        break;

                    case 4:
                        // Create a Cube object, set its data, and add it to the list
                        Cube cube = new Cube();
                        cube.SetData();
                        shapes.Add(cube);
                        break;

                    case 5:
                        // Create a Ellipse object, set its data, and add it to the list
                        Ellipse ellipse = new Ellipse();
                        ellipse.SetData();
                        shapes.Add(ellipse);
                        break;

                    case 6:
                        // Create a Circle object, set its data, and add it to the list
                        Circle circle = new Circle();
                        circle.SetData();
                        shapes.Add(circle);
                        break;

                    case 7:
                        // Create a Cylinder object, set its data, and add it to the list
                        Cylinder cylinder = new Cylinder();
                        cylinder.SetData();
                        shapes.Add(cylinder);
                        break;

                    case 8:
                        // Create a Sphere object, set its data, and add it to the list
                        Sphere sphere = new Sphere();
                        sphere.SetData();
                        shapes.Add(sphere);
                        break;

                    case 9:
                        // Create a Triangle object, set its data, and add it to the list
                        Triangle triangle = new Triangle();
                        triangle.SetData();
                        shapes.Add(triangle);
                        break;

                    case 10:
                        // Create a Tetrahedron object, set its data, and add it to the list
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

                        // Iterate through the list of shapes and display their information
                        foreach (Shape shape in shapes)
                        {
                            Console.WriteLine(shape);
                            Console.WriteLine(new string('-', 60));
                        }

                        // Prompt the user to press any key to exit
                        Console.WriteLine("Press any key to exit..");
                        Console.ReadKey();

                        // Set the flag to true to exit the menu loop
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
