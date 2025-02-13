using ClassLibrary;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // ПРОТЕСТИРОВАТЬ СЛЕДУЮЩИМ ОБРАЗОМ:
        // 1. Прямой числовой тест (Пример. Квадрат: вход 16, вывод 16)
        // 2. С отрицательными значениями и 0
        // 3. С буквенными выражениями

        // ШАБЛОН НАПИСАНИЯ НАЗВАНИЙ ТЕСТОВ:
        // НазваниеФигуры_вход_ожидаемыйвыход

        // тесты для ромба из двух правильных треугольников
        [TestMethod]
        public void Rhombus_16_1386Returns()
        {
            //Подготовка
            string perimeter = "16";
            double expected = 13.86;
            //Действие
            var result = Farmer.Rhombus(perimeter);
            //Проверка
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Rhombus_neg16_ErrorReturns()
        {
            //Подготовка
            string perimeter = "-16";
            //Действие
            var result = Assert.ThrowsException<Exception>(() => Farmer.Rhombus(perimeter));
            //Проверка
            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rhombus_0_ErrorReturns()
        {
            //Подготовка
            string perimeter = "0";
            //Действие
            var result = Assert.ThrowsException<Exception>(() => Farmer.Rhombus(perimeter));
            //Проверка
            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rhombus_string_ErrorReturns()
        {
            //Подготовка
            string perimeter = "asdf";
            //Действие
            var result = Assert.ThrowsException<Exception>(() => Farmer.Rhombus(perimeter));
            //Проверка
            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для круга
        [TestMethod]
        public void Circle_18_2025Returns()
        {
            string perimeter = "18";
            double expected = 25.78;

            var result = Farmer.Circle(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Circle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Circle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Circle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Circle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Circle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Circle(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для пятиугольника
        [TestMethod]
        public void CorPentagon_20_2753Returns()
        {
            string perimeter = "20";
            double expected = 27.53;

            var result = Farmer.CorPentagon(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorPentagon_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorPentagon(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorPentagon_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorPentagon(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorPentagon_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorPentagon(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для шестиугольника
        [TestMethod]
        public void CorHexagon_24_4157Returns()
        {
            string perimeter = "24";
            double expected = 41.58;

            var result = Farmer.CorHexagon(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorHexagon_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorHexagon(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorHexagon_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorHexagon(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorHexagon_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorHexagon(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для прямоугольника
        [TestMethod]
        public void Rectangle_16_1762Returns()
        {
            string perimeter = "16";
            double expected = 14.22;

            var result = Farmer.Rectangle(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Rectangle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Rectangle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rectangle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Rectangle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rectangle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Rectangle(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для квадрата
        [TestMethod]
        public void Square_25_3906Returns()
        {
            string perimeter = "20";
            double expected = 25;
            
            var result = Farmer.Square(perimeter);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Square_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Square_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для правильного треугольника
        [TestMethod]
        public void CorTriangle_15_1083Returns()
        {
            string perimeter = "15";
            double expected = 10.83;

            var result = Farmer.CorTriangle(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorTriangle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorTriangle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorTriangle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorTriangle(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorTriangle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorTriangle(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // тесты для н-угольника
        [TestMethod]
        public void CorNgon_16_16returns()
        {
            string perimeter = "16";
            int sides = 4;
            double expected = 16;

            var result = Farmer.CorNgon(perimeter, sides);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorNgon_negNumber_ErrorReturns()
        {
            string perimeter = "-16";
            int sides = 4;

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorNgon(perimeter, sides));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorNgon_string_ErrorReturns()
        {
            string perimeter = "sdaasf";
            int sides = 4;

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorNgon(perimeter, sides));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }

        [TestMethod]
        public void CorNgon_0sides_ErrorReturns()
        {
            string perimeter = "16";
            int sides = 0;

            var result = Assert.ThrowsException<Exception>(() => Farmer.CorNgon(perimeter, sides));

            Assert.AreEqual(Farmer.invalidSidesEx, result.Message);
        }
    }
}