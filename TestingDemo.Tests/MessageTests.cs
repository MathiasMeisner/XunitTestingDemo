using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestingDemo;
using Xunit;

namespace TestingDemo.Tests
{
    public class MessageTests
    {
        private readonly MessageAdder messageAdder;


        public MessageTests()
        {
            messageAdder = new MessageAdder();
        }


        [Fact]
        public void IsMessageAdded_ShouldPass()
        {
            // arrange
            string message = "Hej";
            string sender = "Mathias";

            // act
            bool isAdded = messageAdder.IsMessageAdded(message, sender);

            // assert
            Assert.True(isAdded);
        }

        [Theory]
        [InlineData("hej", "Mathias")]
        public void IsMessageAdded_ShouldFail(string message, string sender)
        {
            // arrange

            // act
            bool isAdded = messageAdder.IsMessageAdded(message, sender);

            // assert

            Assert.False(isAdded);
        }
    }
}
