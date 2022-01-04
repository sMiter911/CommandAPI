using Xunit;
using System;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests
    {
        [Fact]
        public void ChangeHowTo()
        {
            // Arrange
            var testCommand = new Command
            {
                HowTo = "Do something Wild!!!",
                Platform = "xUnit",
                CommandLine = "dotnet test",
            };

            // Act
            testCommand.HowTo = "Execute Unit Tests";
            testCommand.Platform = "MsTest";
            testCommand.CommandLine = "mstest test";

            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
            Assert.Equal("MsTest", testCommand.Platform);
            Assert.Equal("mstest tests", testCommand.CommandLine);

        }
    }
}