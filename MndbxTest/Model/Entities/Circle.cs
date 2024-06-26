using System;

using MndbxTest.Model.Base;

namespace MndbxTest.Model.Entities {

    public class Circle : CircularShape {

        public Circle() { }

        public Circle(double radius) {
            if (radius < 0) 
                throw new ArgumentException("В конструктор круга передано отрицательное значение радиуса");
            Radius = radius;
        }

        public double Radius { get; set; } = 0;

        public double Diameter { get => Radius * 2; }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

    }

}

