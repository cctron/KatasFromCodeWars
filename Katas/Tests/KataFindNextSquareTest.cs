using System;
using System.Linq;
using Xunit;


namespace Katas.Tests
{
    public class KataFindNextSquareTest
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal(-1, KataFindNextSquare.FindNextSquare(155));
            Assert.Equal(144, KataFindNextSquare.FindNextSquare(121));
            Assert.Equal(676, KataFindNextSquare.FindNextSquare(625));
            Assert.Equal(320356, KataFindNextSquare.FindNextSquare(319225));
            Assert.Equal(15241630849, KataFindNextSquare.FindNextSquare(15241383936));

        }
    }
}
