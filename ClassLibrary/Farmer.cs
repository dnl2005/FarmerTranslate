using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Farmer
    {

        /// <summary>
        /// Метод для нахождения площади ромба
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>
        /// <param name="side">  Сторона ромба  </param>
        /// <param name="area">  Площадь ромба  </param>
        /// <returns> Возаращет площадь ромба </returns>
        public static double Rhombus(double perimeter)
        {
            double side = perimeter / 4;
            return side * side;
        }
        /// <summary>
        /// Метод для нахождения площади круга
        /// </summary>
        /// <param name="perimeter">  Периметр круга  </param>
        /// <param name="radius">  Радиус круга  </param>
        /// <param name="area">  Площадь круга  </param>
        /// <returns> Возаращет площадь круга </returns>
        public static double Circle(double perimeter)
        {
            double radius = perimeter / (2 * Math.PI);
            return radius * radius * Math.PI;
        }

        /// <summary>
        /// Метод для нахождения площади пятиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр пятиугольника  </param>
        /// <param name="side">  Сторона пятиугольника  </param>
        /// <param name="area">  Площадь пятиугольника  </param>
        /// <returns> Возаращет площадь пятиугольника </returns>
        public static double CorPentagon(double perimeter)
        {
            double side = perimeter / 5;
            return 5 * Math.Pow(side, 2) / Math.Tan(Math.PI/5) / 4;
        }

        /// <summary>
        /// Метод для нахождения площади шестиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр шестиугольника  </param>
        /// <param name="side">  Сторона шестиугольника  </param>
        /// <param name="area">  Площадь шестиугольника  </param>
        /// <returns> Возаращет площадь шестиугольника </returns>
        public static double CorHexagon(double perimeter)
        {
            double side = perimeter / 6;
            return 3 * Math.Sqrt(3) * Math.Pow(side, 2) / 2 ;
        }

        /// <summary>
        /// Метод для нахождения площади прямоугольника
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <param name="side">  Сторона прямоугольника  </param>
        /// <param name="area">  Площадь прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        public static double Rectangle(double perimeter)
        {
            return perimeter * perimeter / 18;
        }

        /// <summary>
        /// Метод для нахождения площади квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <param name="side">  Сторона квадрата  </param>
        /// <param name="area">  Площадь квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        public static double Square(double perimeter)
        {
            return Math.Pow(perimeter / 4, 2);
        }

        /// <summary>
        /// Метод для нахождения площади правильного треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр правильного треугольника  </param>
        /// <param name="side">  Сторона правильного треугольника  </param>
        /// <param name="area">  Площадь правильного треугольника  </param>
        /// <returns>  Возаращет площадь правильного треугольника  </returns>
        public static double CorTriangle(double perimeter)
        {
            return Math.Sqrt(3) * Math.Pow(perimeter, 2) / 36;
        }

        /// <summary>
        /// Метод для нахождения площади n-угольника
        /// </summary>
        /// <param name="perimeter">  Периметр n-угольника  </param>
        /// <param name="side">  Сторона n-угольника  </param>
        /// <param name="area">  Площадь n-угольника  </param>
        /// <returns>  Возаращет площадь n-уго  </returns>
        public static double CorNgon(double perimeter, int sides)
        {
            double side = perimeter / sides;
            return sides * Math.Pow(side,2) / Math.Tan(Math.PI / sides) / 4;
        }
    }
}