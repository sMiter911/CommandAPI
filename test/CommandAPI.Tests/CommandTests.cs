using Xunit;
using System;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests: IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some Platform",
                CommandLine = "Some Comman dLine"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void ChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Execute Unit Tests";

            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);

        }
        [Fact]
        public void canChangePlatform()
        {
            // Arrange

            // Act
            testCommand.Platform = "xUnit";

            // Assert
            Assert.Equal("xUnit", testCommand.Platform);

        }
        [Fact]
        public void canChangeCommandLine()
        {
            // Arrange

            // Act
            testCommand.CommandLine = "dotnet test";

            // Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);

        }
    }
}