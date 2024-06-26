using System;
using MndbxTest.Model.Base;

namespace MndbxTest {

    /// <summary>
    /// Калькулятор площади фигур
    /// </summary>
    public static class AreaCalculator {

        /// <summary>
        /// Рассчитать площадь фигуры
        /// </summary>
        /// <typeparam name="T">Тип фигуры</typeparam>
        /// <returns></returns>
        public static double GetShapeArea<T>(T shape) where T : IGeometricShape => shape != null ? Math.Round(shape.GetArea(), 2) : default;

        /// <summary>
        /// Рассчитать площади по списку фигур
        /// </summary>
        /// <typeparam name="T">Тип фигуры</typeparam>
        public static IEnumerable<double> GetShapeArea<T>(IEnumerable<T> shapes) where T : IGeometricShape => shapes.Select(x => GetShapeArea(x));

    }
}

