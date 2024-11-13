using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyXuatPhanTu
{
    [TestFixture]
    internal class XuatPhanTu
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
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = 5)]
        [TestCase(new int[] { -10, 20, 30 }, 2, ExpectedResult = 30)]
        public int GetElementAtIndex_ReturnsExpectedResult(int[] a, int b)
        {
            return _math.XPT(a, b);
        }

        //ngoài phạm vi
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { -10, 20, 30 }, 3)]
        public void GetElementAtIndex_ThrowsIndexOutOfRangeException(int[] a, int b)
        {
            Assert.Throws<IndexOutOfRangeException>(() => _math.XPT(a, b));
        }
        public class Class
        {
            public int XPT(int[] a, int b)
            {
                if (b < 0 || b >= a.Length)
                {
                    throw new IndexOutOfRangeException("Phần tử nằm ngoài phạm vi của mảng.");
                }
                return a[b];
            }

        }
    }
}
