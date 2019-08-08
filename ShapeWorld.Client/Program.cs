using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Rectangle someShape = new Rectangle();
          Square someSquare = new Square();
          // Rectangle someShape = new Rectangle();
          // Rectangle someRectangle = new Rectangle() as Square;
         
          // someShape.NumberOfEdges = 10;
          // someShape.NumberOfEdges = 100;;

          someSquare.Length = 10;
          someSquare.Width = 100;

          //Console.WriteLine(someShape.NumberOfEdges);
          Console.WriteLine(someSquare.NumberOfEdges);
          Console.WriteLine(someShape.Volume());
        }
    }
}
