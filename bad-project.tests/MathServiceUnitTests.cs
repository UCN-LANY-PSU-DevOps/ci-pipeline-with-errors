using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bad_project.tests;

public class MathServiceUnitTests
{
    [Fact]
    public void CalculateSumWithMoq_ReturnsCorrectResult()
    {
        var mockCalculator = new Mock<ICalculator>();
        mockCalculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(16);

        var mathService = new MathService(mockCalculator.Object);
        int[] numbers = [1, 2, 3, 4, 5];
        Assert.Equal(15, mathService.CalculateSum(numbers)); // Fejlen her: 1+2+3+4+5=15, men er det det der returneres?
    }

    [Fact]
    public void CalculateSumWithFake_ReturnsCorrectResult()
    {
        var calculator = new FakeCalculator();
        var mathService = new MathService(calculator);
        int[] numbers = [1, 2, 3, 4, 5];
        Assert.Equal(15, mathService.CalculateSum(numbers)); // Fejlen her: 1+2+3+4+5=15, men er det det der returneres?
    }

    class FakeCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return 16;
        }
    }
}
