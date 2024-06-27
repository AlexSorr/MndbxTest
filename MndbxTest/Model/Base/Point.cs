using System;

namespace MndbxTest.Model.Base {

    /// <summary>
    /// Модель точки в ситеме координат
    /// </summary>
    public class Point {

        public Point() { }

        public Point(int x, int y) {
            CoordinateX = x;
            CoordinateY = y;
        }

        #region Properties

        public int CoordinateX { get; set; } = 0;

        public int CoordinateY { get; set; } = 0;

        #endregion

        public override bool Equals(object obj) {
            Point secondPoint = obj as Point;
            if (secondPoint == null)
                return false;
            return ReferenceEquals(this, secondPoint) || (CoordinateX == secondPoint.CoordinateX && CoordinateY == secondPoint.CoordinateY);
        }

        public static bool operator ==(Point firstPoint, Point secondPoint) {
            if (firstPoint is null || secondPoint is null)
                return false;
            return firstPoint.Equals(secondPoint);
        }

        public static bool operator !=(Point firstPoint, Point secondPoint) => !(firstPoint == secondPoint);

        public override int GetHashCode() => CoordinateX ^ CoordinateY;

    }
}

