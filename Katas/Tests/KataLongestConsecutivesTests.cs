using Katas.Business;
using System;
using System.Linq;
using Xunit;

namespace Katas.Tests
{
    public class KataLongestConsecutivesTests
    {
        [Fact]
        public void xUnitTest()
        {
            Console.WriteLine("Basic Tests");
            testing("abigailtheta", KataLongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
            testing("oocccffuucccjjjkkkjyyyeehh",
                KataLongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1));
            testing("", KataLongestConsecutives.LongestConsec(new String[] { }, 3));
            testing("wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck",
                KataLongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2));
            testing("wlwsasphmxxowiaxujylentrklctozmymu",
                KataLongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2));
            testing("",KataLongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2));
            testing("ixoyx3452zzzzzzzzzzzz", KataLongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3));
            testing("", KataLongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15));
            testing("", KataLongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0));
        }

        private static void testing(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
