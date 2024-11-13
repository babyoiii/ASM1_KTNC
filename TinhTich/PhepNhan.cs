using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTich
{
    internal class PhepNhan
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

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        [TestCase(-5, -5, 25)]
        [TestCase(-10, 2, -20)]
        [TestCase(10, -2, 20)]
        [TestCase(int.MaxValue, -1, -int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]

        public void TinhTich(int a, int b, int c)
        {
            var result = _math.Nhan(a, b);
            Assert.That(result, Is.EqualTo(c));
        }      

        public class Class
        {
            public int Nhan(int a, int b)
            {
                if (b * 1 != 0 && a * 1 != 0)
                {
                    throw new ArgumentException("Số không phải là số nguyên");
                }
                return a * b;
            }
            
        }
    }
}
