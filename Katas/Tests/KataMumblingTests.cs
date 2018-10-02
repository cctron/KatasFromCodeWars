using System;
using System.Linq;
using Xunit;

namespace Katas.Tests
{
    public class KataMumblingTests
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu",
                KataMumbling.Accum("ZpglnRxqenU"));
            Assert.Equal("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb",
                KataMumbling.Accum("NyffsGeyylB"));
            Assert.Equal("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu",
                KataMumbling.Accum("MjtkuBovqrU"));
            Assert.Equal("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm",
                KataMumbling.Accum("EvidjUnokmM"));
            Assert.Equal("H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc",
                KataMumbling.Accum("HbideVbxncC"));
        }
    }
}
