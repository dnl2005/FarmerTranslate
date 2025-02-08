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


        // ������� ��� ��������
        [TestMethod]
        public void Square_16_16eturns()
        {
            string perimeter = "16";
            double expected = 16;

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