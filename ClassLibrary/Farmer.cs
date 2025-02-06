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
        static double Triangle(double Perimeter)
        {
            double area = Math.Sqrt(3) * Math.Pow(Perimeter, 2) / 36;
            return area;
        }
    }
}
