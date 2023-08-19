namespace bug_fixing;

class Program
{
    static void Main(string[] args)
    {

        //try
        //{
        //Console.WriteLine("please enter your name");
        //string userName = Console.ReadLine();
        //Console.WriteLine("please enter your birthday");
        //int userAge = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"can we call you {userName} and your age is {2023 - userAge }");
        //Console.ReadLine();

        //} catch(OverflowException error)

        //{
        //    Console.WriteLine($"there is an error happend in taking the values in {error.Message}");
        //}
        //catch (FormatException error)

        //{
        //    Console.WriteLine($"there is an error happend in taking the values in {error.Message}");
        //}
        //finally
        //{
        //    Console.WriteLine("final method");
        //    Console.Clear();
        //}
        square();

        _ = Console.ReadKey();
    }
    private static void square()
    {
        int[] arr = new int[3] { 2, 4, 8 };
        foreach (int num in arr)
        {
            Console.WriteLine("the element :" + num);
        };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("the element is: " + arr[i]);
        }
    }

}