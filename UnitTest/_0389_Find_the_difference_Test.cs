﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0389.Find_the_difference;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0389.Find_the_difference.Tests
{
    [TestClass()]
    public class _0389_Find_the_difference_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void FindTheDifference_Test1()
        {
            // Arrange
            string s = "abcd";
            string t = "abcde";
            char expected = 'e';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test2()
        {
            // Arrange
            string s = "";
            string t = "y";
            char expected = 'y';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test3()
        {
            // Arrange
            string s = "a";
            string t = "aa";
            char expected = 'a';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test4()
        {
            // Arrange
            string s = "ae";
            string t = "aea";
            char expected = 'a';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}