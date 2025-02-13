using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Drawing;
using System.Formats.Asn1;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.Json.Serialization.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            if (!double.TryParse(perimeter, out per))
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
        /// Метод для нахождения площади ромба с углом в 60 градусов
        /// </summary>
        /// <param name="perimeter">  Периметр ромба  </param>  
        /// <returns> Возаращет площадь ромба </returns>
        public static double Rhombus(string perimeter)
        {
            //площадь ромба равна площади двух равных правильных треугольников Sтр, из которых он состоит
            //сторона такого треугольника равна стороне ромба => a = P/4*3
            //Sромб = 2*Sтр

            double per = ErrorDispatcher(perimeter);
            double corTrianglePerimeter = per / 4 * 3; //сторона 1 из 2 треугольников
            double area = CorTriangle(corTrianglePerimeter.ToString()) * 2; // площадь ромба
            return Math.Round(area,2);
        }
        /// <summary>
        /// Метод для нахождения площади круга
        /// </summary>
        /// <param name="perimeter">  Периметр круга  </param>
        /// <returns> Возаращет площадь круга </returns>
        public static double Circle(string perimeter)
        {
            //площадь круга находится через его радиус 
            //радиус r = P/(2*π)
            //площадь S = r²*π

            double per = ErrorDispatcher(perimeter);
            double radius = per / (2 * Math.PI); // радиус круга
            double area = Math.Pow(radius, 2) * Math.PI; //площадь круга


            return Math.Round(area,2);

        }

        /// <summary>
        /// Метод для нахождения площади пятиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр пятиугольника  </param>
        /// <returns> Возаращет площадь пятиугольника </returns>
        public static double CorPentagon(string perimeter)
        {
            // площадь равнобедренного треугольника состоит из 2 равных прямоугольных треугольников
            // один из углов таких треугольников равен 36 (тот, что ближе к центру описанной окр)
            //катет, не являющийся высотой равнобедренного треугольника, равен a/2
            // площадь одного прямоуг треугольника = (1/2) * (a/2) * h
            // в прямоуг треугольнике tan(36°) = (a/2) / h  =>  h = (a/2) / tan(36°)
            // площадь равнобедренного треугольника равна 2 * (1/2) * (a/2)  * h = a/2*h
            // площадь пятиугольника = 5 * площадь одного треугольника

            double per = ErrorDispatcher(perimeter);
            double baseTriangle = per / 5; // основание треугольника
            double angleDeg = 36.0; //угол прямоугольного треугольника возле центра окр в градусах
            double halfSide = baseTriangle / 2; //катет треугольника, не являющийся высотой 

            double angleRad = angleDeg * Math.PI / 180; //перевод угла в радианы
            double h = halfSide / Math.Tan(angleRad); //нахождение высоты

            double areaTriangle = halfSide * h; //площадь равнобедренного треугольника 

            double areaPentagon = 5 * areaTriangle;//площадь пятиугольника
            return Math.Round(areaPentagon,2);
        }

        /// <summary>
        /// Метод для нахождения площади шестиугольника
        /// </summary>
        /// <param name="perimeter">  Периметр шестиугольника  </param>
        /// <returns> Возаращет площадь шестиугольника </returns>
        public static double CorHexagon(string perimeter)
        {
            //площадь шестиугольника равна площадям 6 правильных треугольников, которые его составляют
            //периметр таких треугольников равен трем сторонам шестиугольника

            double per = ErrorDispatcher(perimeter);
            double perTriangle = per / 2; //периметр треугольника
            double area = 6 * CorTriangle(perTriangle.ToString());
            return Math.Round(area,2);
        }


        /// <summary>
        /// Метод для нахождения площади прямоугольника, где одна сторона в 2 раза больше другой 
        /// </summary>
        /// <param name="perimeter">  Периметр прямоугольника  </param>
        /// <returns>  Возаращет площадь прямоугольника  </returns>
        public static double Rectangle(string perimeter)
        {
            //меньшая сторона прямоугольника вычисляется по формуле P=2(a+2a) = 6a => a = P/6
            //площадь прямоугольника равна произведению его сторон a*2a

            double per = ErrorDispatcher(perimeter);
            double side = per / 6; //меньшая сторона прямоугольника
            double area = side * 2 * side; //площадь прямоугольника
            return Math.Round(area,2);
        }


        /// <summary>
        /// Метод для нахождения площади ``квадрата
        /// </summary>
        /// <param name="perimeter">  Периметр квадрата  </param>
        /// <returns>  Возаращет площадь квадрата  </returns>
        public static double Square(string perimeter)
        {
            //сторона квадрата равна 1/4 его периметра 
            //площадь квадрата равна его стороне в квадрате

            double per = ErrorDispatcher(perimeter);
            double side = per / 4; //сторона квадрата
            double area = Math.Pow(side, 2); //площадь квадрата
            return Math.Round(area,2);
        }


        /// <summary>
        /// Метод для нахождения площади правильного треугольника
        /// </summary>
        /// <param name="perimeter">  Периметр правильного треугольника  </param> 
        /// <returns>  Возаращет площадь правильного треугольника  </returns>
        public static double CorTriangle(string perimeter)
        {
            //сторона правильного треугольника вычисляется по a=p/3
            //площадь правильного треугольника вычисялется по s=√3*a²/4

            double per = ErrorDispatcher(perimeter);
            double side = per / 3; //сторона треугольника
            double area = Math.Sqrt(3) * Math.Pow(side, 2) / 4; //площадь правильного треугольника
            return Math.Round(area,2);
        }
        /// Метод для нахождения площади n-угольника
        /// </summary>
        /// <param name="perimeter">  Периметр n-угольника  </param>
        /// <param name="sides">  Кл-во сторон n-угольника  </param>
        /// <returns>  Возаращет площадь n-угольника  </returns>
        public static double CorNgon(string perimeter, int sides)
        {
            double per = ErrorDispatcher(perimeter);
            double side = per / sides;
            double areaTotal = 0;

            //площадь n-угольника состоит из нескольких теругольников: Sn = n*Sтр
            //площадь треугольника Sтр = 1/2 * a * h
            //h будет равно a/2 * ctg(alpha/2), где alpha - центральный угол треугольника, alpha = 2*PI/n
            //тогда Sтр = a*a*ctg(alpha/2)/4

            if (sides > 4)
            {
                double angle = 2 * Math.PI / sides; //центральный угол треугольника
                double areaTriangle = (side * side / Math.Tan(angle / 2)) / 4;//площадь одного треугольника
                areaTotal = sides * areaTriangle;//тотальная площадь
                return Math.Round(areaTotal,2);
            }
            else if (sides == 4)
            {
                return Square(perimeter);//частный случай для правильного четырехугольника, т.е. квадрата
            }
            else if (sides == 3)
            {
                return CorTriangle(perimeter);//частный случай для правильного треугольника
            }
            else
            {
                throw new Exception(invalidSidesEx);//многоугольника с двумя и меньше сторонами не существует, поднимаем ощибку
            }
        }
    }
}
    