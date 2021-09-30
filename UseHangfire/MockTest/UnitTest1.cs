using System;
using Xunit;
using Moq;

namespace MockTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<ICartService>();
            mock.Setup(cartService => cartService.AddToCart(1)).Returns(1);
            mock.Setup(cartService => cartService.AddToCart(2)).Returns(2);
            var cartService = mock.Object;

            var reuslt = cartService.AddToCart(2);

            Assert.Equal(2, reuslt);
        }
    }
}
