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
        public void Input_2_ShouldReturn_1()
        {
            var input =2;
            var expect = 1;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_3_ShouldReturn_2()
        {
            var input = 3;
            var expect = 2;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_4_ShouldReturn_1()
        {
            var input = 4;
            var expect = 1;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_5_ShouldReturn_2()
        {
            var input = 5;
            var expect = 2;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_8_ShouldReturn_1()
        {
            var input = 8;
            var expect = 1;
            AssertShoudBe(expect, input);
        }

        [TestMethod]
        public void Input_7_ShouldReturn_1()
        {
            var input = 7;
            var expect = 3;
            AssertShoudBe(expect, input);
        }


        [TestMethod]
        public void Input_0_ShouldReturn_0()
        {
            var input = 0;
            var expect = 0;
            AssertShoudBe(expect, input);
        }

        private void AssertShoudBe(int expect, int input)
        {
            var BC = new BitCounting();
            int actual = BC.getNumberOfBit(input);
            Assert.AreEqual(expect, actual);
        }
    }

    public class BitCounting
    {
        public int getNumberOfBit(int input)
        {
            var count = 0;
            for (var i = input; i > 0; i = i / 2)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
