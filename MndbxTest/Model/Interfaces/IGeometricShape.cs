using System;

namespace MndbxTest.Model.Base {

    /// <summary>
    /// Интерфейс геометрической фигуры
    /// </summary>
    public interface IGeometricShape {

        /// <summary>
        /// Рассчитать площадь фигуры
        /// </summary>
        /// <returns></returns>
        double GetArea();

    }
}

