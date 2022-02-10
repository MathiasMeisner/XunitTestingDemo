using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestingDemo;
using System.IO;

namespace TestingDemo.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name");

            Assert.True(actual.Length > 10);
        }


        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => Examples.ExampleLoadTextFile(""));
        }
    }
}
