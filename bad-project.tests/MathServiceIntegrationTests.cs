using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bad_project.tests
{
    public class MathServiceIntegrationTests
    {
        [Fact]
        public void CalculateSum_ReturnsIncorrectResult()
        {
            var mathService = new MathService(new Calculator());
            int[] numbers = { 1, 2, 3, 4 };
            int result = mathService.CalculateSum(numbers);

            // Fejlen her: 1+2+3+4=10, ikke 11
            Assert.Equal(11, result);
        }
    }
}
