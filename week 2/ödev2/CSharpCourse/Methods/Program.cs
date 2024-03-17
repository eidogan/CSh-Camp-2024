namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        //Add();
        //var result=Add2(20,3);

        //int num1 = 20;
        //int num2 = 100;
        //var result = Add3(ref num1, num2);

        //Console.WriteLine(result);
        //Console.WriteLine(num1); //num1 artık ref değer olduğu için metoddan aldığı değer sabit kalır!


        Console.WriteLine(Multiply(2,4,3));
        Console.WriteLine(Multiply(2, 4));

        Console.WriteLine(Add5(2,3,5,5,63,3));

        Console.ReadLine();
    }

    static void Add() //method
    {
        Console.WriteLine("Added!");
    }

    static int Add2(int num1, int num2 = 30) //num2 verilmezse defaultta 30 olarak al!
                                             //default değere sahip değişkenler en sona yazılmalı!
    {
        var result = num1 + num2;
        return result;
        //return num1 + num2; //ikinci yöntem
    }
    static int Add3(ref int num1, int num2) //mainde değiştirdiğim num1 ile birbirine bağlı olsun istiyorsam ref kullanılır!
    {
        num1 = 30;
        return num1 + num2;
    }
    static int Add4(out int num1, int num2) // out ve ref aynı işi yapar ancak
                                            // ref, değişkenin kendinden önce initialize edilmiş olmasını ister,
                                            // out, değişkene değer atanmamış olsa da çalışır. 

    {
        num1 = 30;
        return num1 + num2;
    }

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static int Multiply(int num1, int num2, int num3)//method overload => ismi aynı kullanabilirsin sıkıntı çıkmaz!
    {
        return num1 * num2 * num3;
    }

    static int Add5(params int[] numbers) // istediğim kadar sayı toplayabilmek için
                                          // params değişkenlerin en sonuna yazılmalıdır!
    {
        return numbers.Sum(); //hazır method sum()
    }
}