using System;
using Xunit;

namespace Katas.Tests
{
    public class KataCountingBitsTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, KataCountingBits.CountBits(0));
            Assert.Equal(1, KataCountingBits.CountBits(4));
            Assert.Equal(3, KataCountingBits.CountBits(7));
            Assert.Equal(2, KataCountingBits.CountBits(9));
            Assert.Equal(2, KataCountingBits.CountBits(10));
        }
    }
}
