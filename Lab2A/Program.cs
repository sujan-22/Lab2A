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
            List<ThreeDimension> shapes3D = new List<ThreeDimension>();
            List<TwoDimension> shapes2D = new List<TwoDimension>();
            int shapes = 0;

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
| 0) List all shapes and exit            ( {shapes} shapes entered so far! )|
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
                        // Create a Rectangle object, set its data, and add it to the list
                    case 1:
                        Rectangle rectangle = new Rectangle();
                        rectangle.SetData();
                        shapes2D.Add(rectangle);
                        break;

                        // Create a Square object, set its data, and add it to the list
                    case 2:
                        Square square = new Square();
                        square.SetData();
                        shapes2D.Add(square);
                        break;

                        // Create a Box object, set its data, and add it to the list
                    case 3:
                        Box box = new Box();
                        box.SetData();
                        shapes3D.Add(box);
                        break;

                        // Create a Cube object, set its data, and add it to the list
                    case 4:
                        Cube cube = new Cube();
                        cube.SetData();
                        shapes3D.Add(cube);
                        break;

                        // Create a Ellipse object, set its data, and add it to the list
                    case 5:
                        Ellipse ellipse = new Ellipse();
                        ellipse.SetData();
                        shapes2D.Add(ellipse);
                        break;

                        // Create a Circle object, set its data, and add it to the list
                    case 6:
                        Circle circle = new Circle();
                        circle.SetData();
                        shapes2D.Add(circle);
                        break;

                        // Create a Cylinder object, set its data, and add it to the list
                    case 7:
                        Cylinder cylinder = new Cylinder();
                        cylinder.SetData();
                        shapes3D.Add(cylinder);
                        break;

                        // Create a Sphere object, set its data, and add it to the list
                    case 8:
                        Sphere sphere = new Sphere();
                        sphere.SetData();
                        shapes3D.Add(sphere);
                        break;

                        // Create a Triangle object, set its data, and add it to the list
                    case 9:
                        Triangle triangle = new Triangle();
                        triangle.SetData();
                        shapes2D.Add(triangle);
                        break;

                        // Create a Tetrahedron object, set its data, and add it to the list
                    case 10:
                        Tetrahedron tetrahedron = new Tetrahedron();
                        tetrahedron.SetData();
                        shapes3D.Add(tetrahedron);
                        break;

                    case 0:
                        Console.WriteLine(" ");
                        Console.WriteLine("Displaying table of " + shapes + " instantiated shapes...");
                        Console.WriteLine(" ");

                        // Define the column headers
                        Console.WriteLine(new string('~', 60));
                        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Type", "Dimensions", "Area", "Volume");
                        Console.WriteLine(new string('~', 60));

                        // Iterate through the list of shapes and display their information
                        foreach (ThreeDimension shape in shapes3D)
                        {
                            Console.WriteLine(shape);
                            Console.WriteLine(new string('-', 60));
                        }  
                        foreach (TwoDimension shape in shapes2D)
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
                shapes = shapes3D.Count + shapes2D.Count;

            }

        }
    }
}
