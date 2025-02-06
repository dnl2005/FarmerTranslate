using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ClassLibrary
{
    public static class Faremer
    {
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
            double area = (5 * side * side / 2) * Math.Sqrt(5+2*Math.Sqrt(5));
            return area;
        }
        static double CorHexagon(double perimeter)
        {
            double side = perimeter / 6;
            double area = (3 * Math.Sqrt(3) / 2) * side * side;
            return area;
        }

        static double Rectangle(double Perimeter)
        {
            double area = Perimeter * Perimeter / 18;
            return area;
        }
        static double Square(double Perimeter)
        {
            double area = Math.Pow(Perimeter / 4, 2);
            return area;
        }
        static double CorTriangle(double Perimeter)
        {
            double area = Math.Sqrt(3) * Math.Pow(Perimeter, 2) / 36;
            return area;
        }
    }
}
