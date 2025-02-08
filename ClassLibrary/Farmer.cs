using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Farmer
    {
        public static readonly string negNullPerEx = "NegativeNullPerimeterValueException";
        public static readonly string invalidPerEx = "InvalidPerimeterValueException";
        public static readonly string invalidSidesEx = "InvalidSidesValueNgonException";
        /// <summary>
        /// Метод для обработки общей ошибки длины периметра
        /// </summary>
        /// <param name="perimeter"> Длина периметра </param>
        /// <exception cref="Exception"> Ошибка неверной длины периметра</exception>
        private static double ErrorDispatcher(string perimeter)
        {
            double per;
            if(!double.TryParse(perimeter, out per))
            {
                throw new Exception(invalidPerEx);
            }

            if (per <= 0)
            {
                throw new Exception(negNullPerEx);
            }

            return per;
        }
        /// <summary>
        /// Метод для нахождения площади ромба
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>
        /// <param name="side">  Сторона ромба  </param>
        /// <param name="area">  Площадь ромба  </param>
        /// <returns> Возаращет площадь ромба </returns>
        public static double Rhombus(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            double side = per / 4;
            return side * side;
        }

        /// <summary>
        /// Метод для нахождения площади круга
        /// </summary>
        /// <param name="perimeter">  Периметр круга  </param>
        /// <param name="radius">  Радиус круга  </param>
        /// <param name="area">  Площадь круга  </param>
        /// <returns> Возаращет площадь круга </returns>
        public static double Circle(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            double radius = per / (2 * Math.PI);
            return radius * radius * Math.PI;
        }

        /// <summary>
        /// Метод для нахождения площади пятиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр пятиугольника  </param>
        /// <param name="side">  Сторона пятиугольника  </param>
        /// <param name="area">  Площадь пятиугольника  </param>
        /// <returns> Возаращет площадь пятиугольника </returns>
        public static double CorPentagon(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            double side = per / 5;
            double areaTotal = 0;
            //площадь 5 состоит из 5 правильных теругольников: Sn = n*Sтр
            //площадь треугольника S = 1/2 *a*h
            //высота равностороннего треугольника(формула) h = a*√3/2
            //площадь равностороннего треугольника S = a^2*√3/4
            ErrorDispatcher(perimeter.ToString());
            double areaTriangle = (side * side * Math.Sqrt(3)) / 4;
            areaTotal = 5 * areaTriangle;
            return areaTotal;
        }

        /// <summary>
        /// Метод для нахождения площади шестиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр шестиугольника  </param>
        /// <param name="side">  Сторона шестиугольника  </param>
        /// <param name="area">  Площадь шестиугольника  </param>
        /// <returns> Возаращет площадь шестиугольника </returns>
        public static double CorHexagon(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            double side = per / 6;
            return 3 * Math.Sqrt(3) * Math.Pow(side, 2) / 2 ;
        }

        /// <summary>
        /// Метод для нахождения площади прямоугольника
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <param name="side">  Сторона прямоугольника  </param>
        /// <param name="area">  Площадь прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        public static double Rectangle(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            return per * per / 18;
        }

        /// <summary>
        /// Метод для нахождения площади квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <param name="side">  Сторона квадрата  </param>
        /// <param name="area">  Площадь квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        public static double Square(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            return Math.Pow(per / 4, 2);
        }

        /// <summary>
        /// Метод для нахождения площади правильного треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр правильного треугольника  </param>
        /// <param name="side">  Сторона правильного треугольника  </param>
        /// <param name="area">  Площадь правильного треугольника  </param>
        /// <returns>  Возаращет площадь правильного треугольника  </returns>
        public static double CorTriangle(string perimeter)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            return Math.Sqrt(3) * Math.Pow(per, 2) / 36;
        }

        /// <summary>
        /// Метод для нахождения площади n-угольника
        /// </summary>
        /// <param name="perimeter">  Периметр n-угольника  </param>
        /// <param name="sides">  Кл-во сторон n-угольника  </param>
        /// <returns>  Возаращет площадь n-угольника  </returns>
        public static double CorNgon(string perimeter, int sides)
        {
            double per = ErrorDispatcher(perimeter.ToString());
            double side = per / sides;
            double areaTotal = 0;
            //площадь n-угольника состоит из нескольких теругольников: Sn = n*Sтр
            //площадь треугольника S = 1/2 *a*h
            //высота равностороннего треугольника(формула) h = a*√3/2
            //площадь равностороннего треугольника S = a^2*√3/4
            
            if (sides >4)
            {
                double areaTriangle = (side * side * Math.Sqrt(3)) / 4;
                areaTotal = (sides) * areaTriangle;
                return areaTotal;
            }
            else if (sides == 4)
            { 
                areaTotal = side * side;
                return areaTotal;
            }
            else if (sides == 3)
            {
                double areaTriangle = side * side * Math.Sqrt(3) / 4;
                areaTotal = areaTriangle;
                return areaTotal;
            }
            else if(sides == 2 || sides == 1 || sides <= 0)
            {
                throw new Exception(invalidSidesEx);
            }
            return 0;
        }
    }
}