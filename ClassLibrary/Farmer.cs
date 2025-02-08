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
        /// Метод для обработки общей ошибки длины периметра
        /// </summary>
        /// <param name="perimeter"> Длина периметра </param>
        /// <exception cref="Exception"> Ошибка неверной длины периметра</exception>
        private static void ErrorDispatcher(double perimeter)
        {
            if (perimeter <= 0)
            {
                throw new Exception("InvalidPerimeterException");
            }
            // принимает периметр который парсится в дабл
            // если не может - значит там строка, ошибка
            //если меньше или равно нулю, то пиздим что периметр 
        }


        /// <summary>
        /// Метод для нахождения площади ромба с углом в 60 градусов
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>  
        /// <returns> Возаращет площадь ромба </returns>
        public static double Rhombus(double perimeter)
        {
            //площадь ромба равна площади двух равных правильных треугольников Sтр, из которых он состоит
            //сторона такого треугольника равна стороне ромба => a = P/4*3
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
            //радиус r = P/(2*π)
            //площадь S = r²*π

            double radius = perimeter / (2 * Math.PI); // радиус круга
            double area = Math.Pow(radius, 2) * Math.PI; //площадь круга
            return area;
        }


        /// <summary>
        /// Метод для нахождения площади пятиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр пятиугольника  </param>
        /// <returns> Возаращет площадь пятиугольника </returns>
        public static double CorPentagon(double perimeter)
        {
            // площадь равнобедренного треугольника состоит из 2 равных прямоугольных треугольников
            // один из углов таких треугольников равен 36 (тот, что ближе к центру описанной окр)
            //катет, не являющийся высотой равнобедренного треугольника, равен a/2
            // площадь одного прямоуг треугольника = (1/2) * (a/2) * h
            // в прямоуг треугольнике tan(36°) = (a/2) / h  =>  h = (a/2) / tan(36°)
            // площадь равнобедренного треугольника равна 2 * (1/2) * (a/2)  * h = a/2*h
            // площадь пятиугольника = 5 * площадь одного треугольника

            double baseTriangle = perimeter / 5; // основание треугольника
            double angleDeg = 36.0; //угол прямоугольного треугольника возле центра окр в градусах
            double halfSide = baseTriangle / 2.0; //катет треугольника 

            double angleRad = angleDeg * Math.PI / 180.0; //перевод угла в радианы
            double h = halfSide / Math.Tan(angleRad); //нахождение высоты

            double areaTriangle = halfSide * h; //площадь равнобедренного треугольника 

            double areaPentagon = 5 * areaTriangle;//площадь пятиугольника
            return areaPentagon;
        }


        /// <summary>
        /// Метод для нахождения площади шестиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр шестиугольника  </param>
        /// <returns> Возаращет площадь шестиугольника </returns>
        public static double CorHexagon(double perimeter)
        {
            //площадь шестиугольника равна площадям 6 правильных треугольников, которые его составляют
            //периметр таких треугольников равен трем сторонам шестиугольника

            double perTriangle = perimeter / 2; //периметр треугольника
            double area = 6 * CorTriangle(perTriangle);
            return area;
        }


        /// <summary>
        /// Метод для нахождения площади прямоугольника, где одна сторона в 2 раза больше другой 
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        public static double Rectangle(double perimeter)
        {
            //меньшая сторона прямоугольника вычисляется по формуле P=2(a+2a) = 6a => a = P/6
            //площадь прямоугольника равна произведению его сторон a*2a

            double side = perimeter / 6; //меньшая сторона прямоугольника
            double area = side * 2 * side; //площадь прямоугольника
            return area;
        }


        /// <summary>
        /// Метод для нахождения площади ``квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        public static double Square(double perimeter)
        {
            //сторона квадрата равна 1/4 его периметра 
            //площадь квадрата равна его стороне в квадрате

            double side = perimeter / 4; //сторона квадрата
            double area = Math.Pow(side, 2); //площадь квадрата
            return area;
        }
        

        /// <summary>
        /// Метод для нахождения площади правильного треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр правильного треугольника  </param> 
        /// <returns>  Возаращет площадь правильного треугольника  </returns>
        public static double CorTriangle(double perimeter)
        {
            //сторона правильного треугольника вычисляется по a=p/3
            //площадь правильного треугольника вычисялется по s=√3*a²/4

            double side = perimeter / 3; //сторона треугольника
            double area = Math.Sqrt(3) * Math.Pow(side, 2) / 4; //площадь правильного треугольника
            return area;
        }


        /// <summary>
        /// Метод для нахождения площади n-угольника
        /// </summary>
        /// <param name="perimeter">  Периметр n-угольника  </param>
        /// <param name="sides">  Кл-во сторон n-угольника  </param>
        /// <returns>  Возаращет площадь n-угольника  </returns>
        public static double CorNgon(double perimeter, int sides)
        {
            double side = perimeter / sides;
            double areaTotal = 0;
            //площадь n-угольника состоит из нескольких теругольников: Sn = n*Sтр
            //площадь треугольника S = 1/2 *a*h
            //высота равностороннего треугольника(формула) h = a*√3/2
            //площадь равностороннего треугольника S = a^2*√3/4
            ErrorDispatcher(perimeter);
            if (sides > 4)
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
            else if (sides == 2 || sides == 1)
            {
                throw new Exception("SidesNgonException");
            }
            else if (sides >= 0)
            {
                throw new Exception("InvalidSidesValueNgonException");
            }
            return 0;
        }
    }
}

