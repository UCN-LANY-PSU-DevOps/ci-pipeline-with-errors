namespace bad_project.tests;

public class CalculatorUnitTests
{
    [Fact]
    public void SimpleCalculation_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 2)); // Fejlen her: 2+2=4, ikke 5
    }

    [Fact]
    public void ComplexCalculation_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        int result = calc.Add(1, 2);
        result = calc.Add(result, 3);
        result = calc.Add(result, 4);
        Assert.Equal(11, result); // Fejlen her: 5+5=10, ikke 11
    }
}
