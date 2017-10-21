using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171021_Codewars_BitCounting
{
    [TestClass]
    public class Kata
    {
        [TestMethod]
        public void Input_1_ShouldRetrun_1()
        {
            var input = 1;
            var expect = 1;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_2_ShouldReturn_2()
        {
            var input =2;
            var expect = 2;
            AssertShoudBe(expect, input);
        }


        private void AssertShoudBe(int expect, int input)
        {
            var BC = new BitCounting();
            int actual = BC.getNumberOfBit(input);
            Assert.AreEqual(expect, input);
        }
    }

    public class BitCounting
    {
        public int getNumberOfBit(int input)
        {
            return input;
        }
    }
}
