using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Faremer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns> Площадь ромба </returns>
        static double CorRhombus(double perimeter)
        {
            double side = perimeter / 4;
            double area = side * side;
            return area;
        }
        static double CorCircle(double perimeter)
        {
            double radius = perimeter / (2 * 3.141592653);
            double area = radius * radius * 3.141592653;
            return area;
        }
        static double CorPentagon(double perimeter)
        {
            double side = perimeter / 5;
            double area = (5 * side * side / 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
            return area;
        }
        static double CorHexagon(double perimeter)
        {
            double side = perimeter / 6;
            double area = (3 * Math.Sqrt(3) / 2) * side * side;
            return area;
        }

        static double CorRectangle(double perimeter)
        {
            double area = perimeter * perimeter / 18;
            return area;
        }
        static double CorSquare(double perimeter)
        {
            double area = Math.Pow(perimeter / 4, 2);
            return area;
        }
        static double CorTriangle(double perimeter)
        {
            double area = Math.Sqrt(3) * Math.Pow(perimeter, 2) / 36;
            return area;
        }

        static double CorNgon(double perimeter, int sides)
        {
            double side = perimeter / sides;
            double area = (sides * side * side / 4) * (1 / Math.Tan(Math.PI / sides));
            return area;
        }
        static double CorPentagon(double perimeter) 
        {
            double side = perimeter / 5;
            double area = (5 * side * side / 2) * Math.Sqrt(5+2*Math.Sqrt(5));
            return area;
        }
        static double CorHexagon(double perimeter)
        {
            double side = perimeter / 6;
            double area = (3 * Math.Sqrt(3) / 2) * side * side;
            return area;
        }

        static double CorRectangle(double perimeter)
        {
            double area = perimeter * perimeter / 18;
            return area;
        }
        static double CorSquare(double perimeter)
        {
            double area = Math.Pow(perimeter / 4, 2);
            return area;
        }
        static double CorTriangle(double perimeter)
        {
            double area = Math.Sqrt(3) * Math.Pow(perimeter, 2) / 36;
            return area;
        }

        static double CorNgon(double perimeter, int sides)
        {
            double side = perimeter / sides;
            double area = (sides*side*side/4) * (1/Math.Tan(Math.PI/sides));
            return area;
        }
    }
}
