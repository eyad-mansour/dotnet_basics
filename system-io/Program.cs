namespace system_io;

class Program
{
    static void Main(string[] args)
    {
        string path = "../../../Template.cshtml";
        string newPath = "../../../newFile.txt";
        createNewFile(newPath);
        checkWords(newPath, "world");
        readAll(path);
        howManyLetters(newPath);

        readThree();
        readLineByLine(path);
        //writeALl(path);
        average();
        maximum();
        Console.ReadKey();
    }
    static void readThree()
    {
        Console.WriteLine("enter three number");
        string input = Console.ReadLine();
        string[] numberStr = input.Split(" ");
        int [] number = new int [numberStr.Length];

        for (int i = 0; i < numberStr.Length; i++)
        {
            if (int.TryParse(numberStr[i], out int parsedInteger))
            {
                number[i] = parsedInteger;
            }
            else
            {
                Console.WriteLine($"you entered {numberStr[i]} invalid value ");
            }
        }
        
        int result = 1;
        foreach (int i in number)
        {
                Console.WriteLine("0");   
                result *= i;
        }

        if (number.Length < 4 && number.Length > 0)
        {
            Console.WriteLine($"the result of pruduct three number is {result}");
        }
        else
        {
            Console.WriteLine(0);
        }

    }

    static void readAll(string path)
    {
        Console.WriteLine(File.ReadAllText(path));
    }

    static void readLineByLine(string path)
    {
        string[] arr = File.ReadAllLines(path);
        int num = 0;
        foreach (string i in arr)
        {
            Console.WriteLine(i);
            Console.WriteLine(num);
            
            num++;
        }
    }
    static void average()
    {
        Console.WriteLine("Please enter a number between 2-10:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"{i+1} of {number} enter a number: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            result += sum;
            
        }
        Console.WriteLine(result/number);
    }

    static void maximum()
    {
        int[] example = new int[] {1,3,5,1,23,26,14};
        int result = 0;
        foreach (int i in example)
        {
            if (i > result)
            {
                result = i;
            }
        }
        Console.WriteLine(result);
    }

    static string createNewFile(string path)
    {
        string content = Console.ReadLine();
        File.WriteAllText(path,content);
        Console.WriteLine("please check on the file if got updated");
        return "";
    }
    static string checkWords(string str, string world)
    {
        string content = File.ReadAllText(str);
        string[] arrStr = content.Split(" ");
        string result = "";
        foreach (string i in arrStr)
        {
            if(i == world)
            {
                result = world;
            }
            //Console.Write(i+" "); to print all the data in the file
        }
        if(result == world)
        {
                Console.WriteLine($"yes the {world} is inside the file");
        }
        else
        {
                Console.WriteLine($"no {world} is not looking like it is in the file");
        }

        Console.WriteLine("");
        return world;
    }
    static void howManyLetters(string str)
    {
        string content = File.ReadAllText(str);
        string[] arrStr = content.Split(" ");
        foreach (string i in arrStr)
        {
            char[] world = i.ToCharArray();
            Console.WriteLine($"{i} is containing: {world.Length} letters");
        }

    }
    //static void writeALl(string path)
    //{

    //    File.WriteAllText(path, "this is the new line \n we can write a new \n line ");
    //}
}
