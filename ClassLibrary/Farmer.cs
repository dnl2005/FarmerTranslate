using System.Formats.Asn1;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Faremer
    {

        /// <summary>
        /// Метод для нахождения площади ромба
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>
        /// <param name="side">  Сторона ромба  </param>
        /// <param name="area">  Площадь ромба  </param>
        /// <returns> Возаращет площадь ромба </returns>
        static double CorRhombus(double perimeter)
        {
            
            double side = perimeter / 4;
            double area = side * side;
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади круга
        /// </summary>
        /// <param name="perimeter">  Периметр круга  </param>
        /// <param name="radius">  Радиус круга  </param>
        /// <param name="area">  Площадь круга  </param>
        /// <returns> Возаращет площадь круга </returns>
        static double Circle(double perimeter)
        {
            double radius = perimeter / (2 * 3.141592653);
            double area = radius * radius * 3.141592653;
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади пятиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр пятиугольника  </param>
        /// <param name="side">  Сторона пятиугольника  </param>
        /// <param name="area">  Площадь пятиугольника  </param>
        /// <returns> Возаращет площадь пятиугольника </returns>
        static double CorPentagon(double perimeter)
        {
            double side = perimeter / 5;
            double area = (5 * side * side / 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади шестиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр шестиугольника  </param>
        /// <param name="side">  Сторона шестиугольника  </param>
        /// <param name="area">  Площадь шестиугольника  </param>
        /// <returns> Возаращет площадь шестиугольника </returns>
        static double CorHexagon(double perimeter)
        {
            double side = perimeter / 6;
            double area = (3 * Math.Sqrt(3) / 2) * side * side;
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади прямоугольника
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <param name="side">  Сторона прямоугольника  </param>
        /// <param name="area">  Площадь прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        static double Rectangle(double perimeter)
        {
            double side = perimeter/6;
            double area = Math.Pow(side,2)*2;
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <param name="side">  Сторона квадрата  </param>
        /// <param name="area">  Площадь квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        static double Square(double perimeter)
        {
            double side = perimeter / 4;
            double area = Math.Pow(side, 2);
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр треугольника  </param>
        /// <param name="side">  Сторона треугольника  </param>
        /// <param name="area">  Площадь треугольника  </param>
        /// <returns>  Возаращет площадь треугольника  </returns>
        static double CorTriangle(double perimeter)
        {
            double side = perimeter / 3;
            double area = Math.Sqrt(3) * Math.Pow(side, 2) / 4;
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади n-угольника
        /// </summary>
        /// <param name="perimeter">  Периметр n-угольника  </param>
        /// <param name="side">  Сторона n-угольника  </param>
        /// <param name="area">  Площадь n-угольника  </param>
        /// <returns>  Возаращет площадь n-уго  </returns>
        static double CorNgon(double perimeter, int sides)
        {
            double side = perimeter / sides;
            double area = (sides * side * side / 4) * (1 / Math.Tan(Math.PI / sides));
            return area;
        }
    }
}
