using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangBeNhat
{
    [TestFixture]
    internal class ViTriBeNhat
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
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = -5)]
        [TestCase(new int[] { 5, 3, 8, 2, 9 }, ExpectedResult = 2)]
        [TestCase(new int[] { 10 }, ExpectedResult = 10)]
        [TestCase(new int[] { int.MaxValue, int.MinValue, 0 }, ExpectedResult = int.MinValue)]
        public int Tim(int[] a)
        {
            return _math.PTMangBeNhat(a);
        }

        //mảng rỗng
        [Test]
        public void Mangrong()
        {
            Assert.Throws<ArgumentException>(() => _math.PTMangBeNhat(new int[] { }));
        }
        public class Class
        {
            public int PTMangBeNhat(int[] a)
            {
                if (a == null || a.Length == 0)
                {
                    throw new ArgumentException("Mảng không được rỗng.");
                }

                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                return min;
            }

        }
    }
}
