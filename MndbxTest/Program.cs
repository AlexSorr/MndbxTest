using System;

using MndbxTest.Model.Base;
using MndbxTest.Model.Entities;

namespace MndbxTest;

public class Program {

    public static void Main(string[] args) {

        Triangle PifagorTriangle = new Triangle(new Point(0, 0), new Point(4, 0), new Point(0, 3));

        Triangle RandomTriangle = new Triangle(new Point(1, 1), new Point(4, 5), new Point(7, 2));

        Circle RandomCircle = new Circle(15);

        var pifagorTrArea = AreaCalculator.GetShapeArea(PifagorTriangle);
        Console.WriteLine($"Площадь треугольника Пифагора: {pifagorTrArea}");

        var randomTrArea = AreaCalculator.GetShapeArea(RandomTriangle);
        Console.WriteLine($"Площадь рандомного треугольника: {randomTrArea}");

        var RandomCircleArea = AreaCalculator.GetShapeArea(RandomCircle);
        Console.WriteLine($"Площадь круга: {RandomCircleArea}");

        //Без явного указания типа
        IEnumerable<IGeometricShape> shapesList = new IGeometricShape[] { PifagorTriangle, RandomTriangle, RandomCircle };
        string areas = string.Join(", ", AreaCalculator.GetShapeArea(shapesList));
        Console.WriteLine($"Площади всех фигур: {areas}");

        Console.ReadKey();
    }
}
