using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Farmer
    {

        /// <summary>
        /// Метод для нахождения площади ромба с углом в 60 градусов
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>  
        /// <returns> Возаращет площадь ромба </returns>
        public static double Rhombus(double perimeter)
        {
            //площадь ромба равна площади двух равных правильных треугольников Sтр, из которых он состоит
            //сторона такого треугольника равна стороне ромба => a=P/4*3
            //Sромб = 2*Sтр
            double corTrianglePerimeter = perimeter / 4 * 3; //сторона 1 из 2 треугольников
            double area = CorTriangle(corTrianglePerimeter) * 2; // площадь ромба
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади круга
        /// </summary>
        /// <param name="perimeter">  Периметр круга  </param>
        /// <returns> Возаращет площадь круга </returns>
        public static double Circle(double perimeter)
        {
            //площадь круга находится через его радиус 
            //r = P/(2*π)
            //s = r²*π
            double radius = perimeter / (2 * Math.PI); // радиус круга
            double area = Math.Pow(radius, 2) * Math.PI; //площадь круга
            return area;
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
            return 5 * Math.Pow(side, 2) / Math.Tan(Math.PI / 5) / 4;
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
            return 3 * Math.Sqrt(3) * Math.Pow(side, 2) / 2;
        }

        /// <summary>
        /// Метод для нахождения площади прямоугольника, где одна сторона в 2 раза больше другой 
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        public static double Rectangle(double perimeter)
        {
            double side = perimeter / 6; //меньшая сторона прямоугольника, получена из формулы P=2(a+2a)=6a => a=P/6
            double area = side * 2 * side; //площадь прямоугольника, s=a*2a
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади ``квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        public static double Square(double perimeter)
        {
            double side = perimeter / 4; //сторона квадрата, равна 1/4 периметра 
            double area = Math.Pow(side, 2); //площадь квадрата, равна его стороне в квадрате
            return area;
        }

        /// <summary>
        /// Метод для нахождения площади правильного треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр правильного треугольника  </param> 
        /// <returns>  Возаращет площадь правильного треугольника  </returns>
        public static double CorTriangle(double perimeter)
        {
            double side = perimeter / 3; //сторона треугольника, a=p/3
            double area = Math.Sqrt(3) * Math.Pow(side, 2) / 4; //площадь правильного треугольника, s=√3*a²/4
            return area;
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
            return sides * Math.Pow(side, 2) / Math.Tan(Math.PI / sides) / 4;
        }
    }
}

