using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bad_project;

public class MathService(ICalculator calculator)
{
    private readonly ICalculator _calculator = calculator;

    public int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum = _calculator.Add(sum, number);
        }
        return sum;
    }
}
