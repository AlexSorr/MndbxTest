using MndbxTest;
using MndbxTest.Model.Entities;
using MndbxTest.Model.Base;

namespace UnitTests;

[TestFixture]
public class GeometryShapesTest {

    /// <summary>
    /// Тестовый треугольник Пифагора - прямоугольный
    /// </summary>
    private  Triangle PifagorTriangle = new Triangle(new Point(0, 0), new Point(4, 0), new Point(0, 3));

    /// <summary>
    /// Рандомный треугольник у которого углы не прямые
    /// </summary>
    private  Triangle RandomTriangle = new Triangle(new Point(1, 1), new Point(4, 5), new Point(7, 2));

    /// <summary>
    /// Круг с радиусом 15
    /// </summary>
    private  Circle RandomCircle = new Circle(15);

    /// <summary>
    /// Попытка создать некорректный треугольник
    /// </summary>
    [Test]
    public void ErrorTriangleTest() {
        Assert.Throws<ArgumentException>(() => { new Triangle(new Point(0, 0), new Point(0, 0), new Point(1, 2)); });
    }

    /// <summary>
    /// Проверяем прямоугольный треугольник
    /// </summary>
    [Test]
    public void IsRightTriangle() {
        Assert.That(PifagorTriangle.IsRightTriangle, Is.True);

        Assert.That(RandomTriangle.IsRightTriangle, Is.False);
    }

    /// <summary>
    /// Проверка рассчета площади треугольников 
    /// </summary>
    [Test]
    public void TriangleAreaTest() {
        double RandomTriangleResult = 10.5; //Ожидаемый результат для RandomTriangle
        double PifagorTriangleResult = 6;

        Assert.That(AreaCalculator.GetShapeArea(RandomTriangle), Is.EqualTo(RandomTriangleResult));
        Assert.That(AreaCalculator.GetShapeArea(PifagorTriangle), Is.EqualTo(PifagorTriangleResult));
    }

    /// <summary>
    /// Рассчет площади круга, тест
    /// </summary>
    [Test]
    public void CircleAreaTest() {
        double expectedRes = Math.Pow(RandomCircle.Radius, 2) * Math.PI;

        Assert.That(AreaCalculator.GetShapeArea(RandomCircle), Is.EqualTo(expectedRes));
    }
}