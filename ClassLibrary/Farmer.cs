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
    }
}
