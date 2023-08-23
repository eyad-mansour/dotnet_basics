namespace bug_fixiing_test;
using bug_fixing;
public class UnitTest1
{
    [Fact]
    public void testfizz()
    {

        // Assert.True(true);
        // Assemble
        int number = 6;
        // Act
        string result = Program.Converts(number);
        // Assert
        Assert.Equal("fizz", result);
    }

    [Fact]
    public void testbuzz()
    {
        int number = 10;

        string result = Program.Converts(number);

        Assert.Equal("buzz",result);
    }

    [Fact]
    public void testFizzBuzz()
    {
        int number = 15;
        string result = Program.Converts(number);
        Assert.Equal("FizzBuzz", result);
    }


    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(5, "5")]
    [InlineData(10, "10")]

    public void testeather(int numToTest, string expectedValue)
    {
        Assert.Equal(expectedValue, Program.Converts(numToTest));
    }

    

}
