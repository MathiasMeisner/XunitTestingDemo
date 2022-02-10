using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo;
using Xunit;

namespace TestingDemo.Tests
{
    public class UserTests
    {
        private User user;

        [Theory]
        [InlineData("Mathias")]
        [InlineData("Bo")]
        public void Name_IsValidShouldWork(string x)
        {
            string actual = x;

            bool expected = actual.Length > 1;

            Assert.True(expected);
        }

        [Theory]
        [InlineData("Mathias")]
        [InlineData("Bo")]
        public void Name_IsValidShouldWork2(string x)
        {
            string actual = x;

            Assert.True(actual.Length > 1);
        }

        [Theory]
        [InlineData("M")]
        public void Name_TooShortShouldFail(string x)
        {
            string actual = x;
            
            Assert.False(actual.Length > 1);
        }

        [Fact]
        public void PhoneNo_IsValidShouldWork()
        {
            int expected = 8;


        }
    }
}
