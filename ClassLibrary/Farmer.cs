
using System;
using System.Data.SqlTypes;
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
        public static double CorRhombus(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }

                double side = perimeter / 4;
                return side * side;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorCircle(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }

                double radius = perimeter / (2 * Math.PI);
                return radius * radius * Math.PI;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorPentagon(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }
                double side = perimeter / 5;
                return (5 * side * side / 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorHexagon(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }

                double side = perimeter / 6;
                return (3 * Math.Sqrt(3) / 2) * side * side;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorRectangle(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }

                return perimeter * perimeter / 18;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorSquare(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }
                return Math.Pow(perimeter / 4, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorTriangle(double perimeter)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }

                return Math.Sqrt(3) * Math.Pow(perimeter, 2) / 36;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }

        public static double CorNgon(double perimeter, int sides)
        {
            try
            {
                if (perimeter <= 0)
                {
                    throw new ArgumentException("Периметр должен быть положительным числом.");
                }
                if (sides < 3)
                {
                    throw new ArgumentException("Многоугольник должен иметь минимум 3 стороны.");
                }

                double side = perimeter / sides;
                return (sides * side * side / 4) * (1 / Math.Tan(Math.PI / sides));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return -1;
            }
        }
    }
}
