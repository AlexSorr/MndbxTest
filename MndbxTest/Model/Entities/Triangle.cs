using System;

using MndbxTest.Model.Base;

namespace MndbxTest.Model.Entities {

    public class Triangle : Polygon {

        public Triangle(Point A, Point B, Point C) {
            if (A == B || A == C || B == C)
                throw new ArgumentException("Для построения треугольника были переданы одинаковые точки!");

            this.A = A;
            this.B = B;
            this.C = C;
        }

        #region Properties

        /// <summary>
        /// Точки треугольника
        /// </summary>

        public Point A { get; } = new Point();

        public Point B { get; } = new Point();

        public Point C { get; } = new Point();

        /// <summary>
        /// Длина сторон треугольника
        /// </summary>
        public double A_SideLength { get => GetSideLengthByTwoPoints(this.A, this.B); }

        public double B_SideLength { get => GetSideLengthByTwoPoints(this.B, this.C); }

        public double C_SideLength { get => GetSideLengthByTwoPoints(this.C, this.A); }

        //max side ^ 2 = other_side1 ^ 2 + other_side2 ^2
        /// <summary>
        /// Является ли прямоугольным
        /// </summary>
        public bool IsRightTriangle {
            get {
                double[] AllSides = new double[3] { A_SideLength, B_SideLength, C_SideLength };
                Array.Sort(AllSides);
                return Math.Pow(AllSides[2], 2) == Math.Pow(AllSides[1], 2) + Math.Pow(AllSides[0], 2);
            }
        }

        #endregion

        //sqrt((xj-xi)^2 + (yj-yi)^2)
        /// <summary>
        /// Получить длину стороны треугольника по трем точкам
        /// </summary>
        private double GetSideLengthByTwoPoints(Point firstPoint, Point secondPoint) {
            if (firstPoint == null || secondPoint == null || firstPoint == secondPoint) {
                return default;
            }
            return Math.Sqrt(
                Math.Pow(secondPoint.CoordinateX - firstPoint.CoordinateX, 2) + Math.Pow(secondPoint.CoordinateY - firstPoint.CoordinateY, 2)
            );
        }

        // 1/2 * |x1​(y2​−y3​)+x2​(y3​−y1​)+x3​(y1​−y2​)∣
        public override double GetArea() {
            double x1 = A.CoordinateX;
            double y1 = A.CoordinateY;

            double x2 = B.CoordinateX;
            double y2 = B.CoordinateY;

            double x3 = C.CoordinateX;
            double y3 = C.CoordinateY;

            return 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
             
        }

    }
}

