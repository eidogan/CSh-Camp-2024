namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        //for (int i = 1; i < 100; i+=2) // tek sayıları yazdırmak
        //{
        //    Console.WriteLine(i);
        //}

        //ForLoop();

        //WhileLoop();

        //DoWhileLoop();

        //ForEachLoop();

        if (IsPrimeNumber(7))
        {
            Console.WriteLine("this is a prime number");
        }
        else
        {
            Console.WriteLine("this is not a prime number");
        }

        Console.WriteLine("finished!");

        Console.ReadLine();
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number%i==0)
            {
                result =false;
                i = number; //şart sağlandığı an döngünün bitmesi için
            }
        }
        return result;
    }

    private static void ForEachLoop()
    {
        string[] students = new string[3] { "engin", "derin", "salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;

        do
        {
            Console.WriteLine(number);
            number--;

        } while (number>=11);
    }

    private static void WhileLoop()
    {
        int number = 100;

        while (number>=0)
        {
            Console.WriteLine(number);
            number--;
        }

        Console.WriteLine("now number is {0}",number);
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i--) // geriye doğru yazdırmak
        {
            Console.WriteLine(i);
        }
    }
}