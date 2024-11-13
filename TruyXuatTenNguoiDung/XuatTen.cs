using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyXuatTenNguoiDung
{

    internal class XuatTen
    {
        static void Main(string[] args)
        {
        }
        private Class _ten;
        [SetUp]
        public void Setup()
        {
            _ten = new Class();
        }
        // Test case kiểm tra khi hồ sơ người dùng hợp lệ
        [Test]
        [TestCase(new[] { "John Doe" }, "John Doe")]
        [TestCase(new[] { "Alice", "AnotherData" }, "Alice")]
        [TestCase(new[] { "" }, "")]
        public void GetName_ReturnsExpectedResult(string[] hoso, string expected)
        {
            var result = _ten.Ten(hoso);
            Assert.That(result, Is.EqualTo(expected));
        }


        //Hồ sơ người dùng là null hoặc rỗng
        [Test]
        public void Ten_ThrowsNullReferenceExceptionForNullOrEmptyProfile()
        {
            Assert.Throws<NullReferenceException>(() => _ten.Ten(null));
            Assert.Throws<NullReferenceException>(() => _ten.Ten(new string[] { }));
        }
    }
    public class Class
    {
        public string Ten(string[] hoso)
        {
            if (hoso == null || hoso.Length == 0)
            {
                throw new NullReferenceException("Hồ sơ người dùng rỗng.");
            }

            return hoso[0];
        }

    }
}
