using System;
using System.Collections.Generic;

namespace ShapeSharp
{
	class Program
	{

		static void Main(string[] args)
		{
			//List for shapes
			List<Shape> ShapesList = new List<Shape>();

			//Shapes, + add to list
			Circle circle1 = new Circle(10);
			circle1.Draw();
			Console.WriteLine($"\tArea of Circle: {circle1.Area}cm^2.\t\n");
			ShapesList.Add(circle1);

			Triangle triangle1 = new Triangle(10, 10);
			triangle1.Draw();
			Console.WriteLine($"\tArea of Triangle: {triangle1.Area}cm^2.\t\n");
			ShapesList.Add(triangle1);

			Square square1 = new Square(10, 10);
			square1.Draw();
			Console.WriteLine($"\tArea of Square: {square1.Area}cm^2.\t\n");
			ShapesList.Add(square1);

			Rectangle rectangle1 = new Rectangle(10, 20);
			rectangle1.Draw();
			Console.WriteLine($"\tArea of Rectangle: {rectangle1.Area}cm^2.\t\n");
			ShapesList.Add(rectangle1);

			Console.WriteLine("\nAll ShapesList objects printed order:\n");
			//Print type of shape
			foreach (Shape shape in ShapesList)
			{
				Console.WriteLine("\t" + shape);
			}

			//Number of items in list
			Console.WriteLine("\n\tNumber of objects: " + ShapesList.Count);
		}
	}
}
