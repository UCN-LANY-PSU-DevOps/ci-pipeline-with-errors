namespace bad_project.tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsIncorrectResult()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 2)); // Fejlen her: 2+2=4, ikke 5
    }
}
