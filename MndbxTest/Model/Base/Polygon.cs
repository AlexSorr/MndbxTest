using System;
namespace MndbxTest.Model.Base {

    /// <summary>
    /// Фигура, имеющая стороны/углы
    /// </summary>
    public abstract class Polygon : IGeometricShape {

        public Polygon() { }

        public abstract double GetArea();

    }
}

