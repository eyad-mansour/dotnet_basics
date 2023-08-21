namespace bug_fixing;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my game! Let's do some math!");
        //int i
        Console.WriteLine("🤣");
        StartSequence();

        //Converts(1);
        Console.ReadKey();
    }

    static void StartSequence()
    {
        Console.WriteLine("please enter a number greater then zero ?");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[number];
        Console.WriteLine(arr);
        int[] first = populate(arr);
        int sum = GetSum(first);
        GetProduct(arr, sum);

    }

    static int[] populate(int[] slam1)
    {
        int arrayLength = slam1.Length;
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine($"please enter a number between {i + 1} and {arrayLength}");
            int num = Convert.ToInt32(Console.ReadLine());
            slam1[i] = num;
        }

        return slam1;
    }

    static int GetSum(int[] slam2)
    {
        int sum = 0;
        foreach (int i in slam2)
        {
            sum += i;
        }
        return sum;
    }

    static int GetProduct(int[] slam3, int slam4)
    {
        Console.WriteLine($"please enter a value between 1 and {slam3.Length}");
        int lemonada = Convert.ToInt32(Console.ReadLine());
        if (lemonada > slam3.Length && lemonada < 0)
        {
            throw new Exception("please enter again ");
        }
        int product = lemonada * slam4;
        Console.WriteLine(product);

        return product;
    }

    public static string Converts(int number)
    {
         if (number % 15 == 0)
              {
                return "FizzBuzz";
              }

        else if (number % 5 == 0)
             {
                    return "buzz";
             }
        else if (number % 3 == 0)
             {
                return "fizz";
             }
        else
            {
                return number.ToString();
            }
    }

    //static int GetQutati

}