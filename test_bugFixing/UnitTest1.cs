namespace test_bugFixing;

public class UnitTest1
{
    [Fact]
    static void test_bugFixing(string[] args)
    {
        Console.WriteLine("Welcome to my game! Let's do some math!");

        Console.ReadKey();
    }
    [Fact]
    public void fizzBuzzTest()
    {
        //assemble
        int number = 6;
        //act
        string result = Program.Convert(number);
        //assert
        Assert.Equal("fizz", result);
    }
}
