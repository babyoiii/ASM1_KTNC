using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrungBinhCong
{
    internal class TBC
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
        //rỗng
        [Test]
        public void TBC_ThrowsExceptionForEmptyArray()
        {
            Assert.Throws<ArgumentException>(() => _math.TBC(new int[] { }));
        }

        // TBC
        [TestCase(new int[] { 10, 10, 10 }, ExpectedResult = 10)]
        [TestCase(new int[] { 1, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -10, -10, -10 }, ExpectedResult = -10)]
        [TestCase(new int[] { 10, -10, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 5, 15, 10 }, ExpectedResult = 10)]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, int.MaxValue }, ExpectedResult = int.MaxValue)]
        [TestCase(new int[] { int.MinValue, int.MinValue, int.MinValue }, ExpectedResult = int.MinValue)]
        [TestCase(new int[] { int.MaxValue, int.MinValue, 0 }, ExpectedResult = 0)]
        public int TBC_TestCase_ReturnsExpectedResult(int[] a)
        {
            return _math.TBC(a);
        }
       
        public class Class
        {
            public int TBC(int[] a)
            {
                if (a.Length == 0)
                {
                    throw new ArgumentException("Mảng không được rỗng");
                }

                int tong = 0;
                foreach (var num in a)
                {
                    tong += num;
                }
                return tong / a.Length;
            }
        }

    }
}
