using Calculator.Services;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTests.Services
{
    public class CalculatorServiceTests
    {
        [InlineData(1, 2, 3)]
        public async Task Add(decimal value1, decimal value2, decimal expectedResult)
        {
            // Arrange
            Mock<IMemoryService> memoryMock = new Mock<IMemoryService>();

            var sut = new CalculatorService(memoryMock.Object);

            // Act
            var result = await sut.Add(value1, value2, null);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
