using ClassLibrary;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // �������������� ��������� �������:
        // 1. ������ �������� ���� (������. �������: ���� 16, ����� 16)
        // 2. � �������������� ���������� � 0
        // 3. � ���������� �����������

        // ������ ��������� �������� ������:
        // ��������������_����_��������������

        // ������� ��� ����� �� ���� ���������� �������������
        [TestMethod]
        public void Rhombus_16_1386Returns()
        {
            //����������
            string perimeter = "16";
            double expected = 13.86;
            //��������
            var result = Farmer.Square(perimeter);
            //��������
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Rhombus_neg16_ErrorReturns()
        {
            //����������
            string perimeter = "-16";
            //��������
            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));
            //��������
            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rhombus_0_ErrorReturns()
        {
            //����������
            string perimeter = "0";
            //��������
            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));
            //��������
            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rhombus_string_ErrorReturns()
        {
            //����������
            string perimeter = "asdf";
            //��������
            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));
            //��������
            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� �����
        [TestMethod]
        public void Circle_18_2579Returns()
        {
            string perimeter = "18";
            double expected = 25.79;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Circle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Circle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Circle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� �������������
        [TestMethod]
        public void CorPentagon_20_2753Returns()
        {
            string perimeter = "20";
            double expected = 27.53;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorPentagon_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorPentagon_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorPentagon_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� ��������������
        [TestMethod]
        public void CorHexagon_24_4157Returns()
        {
            string perimeter = "24";
            double expected = 41.57;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorHexagon_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorHexagon_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorHexagon_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� ��������������
        [TestMethod]
        public void Rectangle_25_3906Returns()
        {
            string perimeter = "25";
            double expected = 39.06;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Rectangle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rectangle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void Rectangle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� ��������
        [TestMethod]
        public void Square_25_3906Returns()
        {
            string perimeter = "25";
            double expected = 39.06;
            
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


        // ������� ��� ����������� ������������
        [TestMethod]
        public void CorTriangle_15_1083Returns()
        {
            string perimeter = "15";
            double expected = 10.83;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CorTriangle_neg16_ErrorReturns()
        {
            string perimeter = "-16";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorTriangle_0_ErrorReturns()
        {
            string perimeter = "0";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.negNullPerEx, result.Message);
        }

        [TestMethod]
        public void CorTriangle_string_ErrorReturns()
        {
            string perimeter = "asdf";

            var result = Assert.ThrowsException<Exception>(() => Farmer.Square(perimeter));

            Assert.AreEqual(Farmer.invalidPerEx, result.Message);
        }


        // ������� ��� �-���������
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