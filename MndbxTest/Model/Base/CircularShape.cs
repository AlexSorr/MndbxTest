using System;

namespace MndbxTest.Model.Base {

    /// <summary>
    /// Фигура, не имеющая углов
    /// </summary>
    public abstract class CircularShape : IGeometricShape {

        public CircularShape() {  }

        public abstract double GetArea();

    }
}

