using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhThuong
{
    [TestFixture]
    internal class PhepChia
    {
        static void Main(string[] args)
        {
        }
        private Class _math;
        [SetUp]
        public void Setup()
        {
            _math = new Class();
        }

        [TestCase(10, 0)]
        public void Chia_TestCase_ThrowsExceptionForDivideByZero(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.Chia(a, b));
        }

        [TestCase(10, 2, ExpectedResult = 5)]
        [TestCase(9, 3, ExpectedResult = 3)]
        [TestCase(-10, 2, ExpectedResult = -5)]
        [TestCase(0, 1, ExpectedResult = 0)]
        [TestCase(int.MaxValue, 1, ExpectedResult = int.MaxValue)]
        [TestCase(int.MinValue, -1, ExpectedResult = int.MinValue)]
        [TestCase(int.MaxValue, -1, ExpectedResult = -int.MaxValue)]
        [TestCase(1, int.MaxValue, ExpectedResult = 1.0 / int.MaxValue)]
        [TestCase(-1, int.MaxValue, ExpectedResult = -1.0 / int.MaxValue)]
        public double Chia_TestCase_ReturnsExpectedResult(double a, double b)
        {
            return _math.Chia(a, b);
        }
     
        public class Class
        {
            public double Chia(double a, double b)
            {
                if (b == 0)
                {
                    throw new ArgumentException("Khong the chia cho 0");
                }

                if (b % 1 != 0 && a % 1 != 0)
                {
                    throw new ArgumentException("Số chia không phải là số nguyên");
                }

                return a / b;
            }
        }


    }
}
