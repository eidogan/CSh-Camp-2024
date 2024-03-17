// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("m");
            string days = "Monday"; // ?????
            double num = 10.4;
            decimal num1 = 10;
            char ch = 'a';
            bool b = true;
            byte num2 = 255;
            short num3 = 32767;
            int num4 = 123456;
            long num5 = 1234567898765432;

            var num6 = 10; //int olarak algılanır

            Console.WriteLine("number1 is {0}", num);
            Console.WriteLine("number2 is {0}", num1);
            Console.WriteLine("number3 is {0}", num2);
            Console.WriteLine("number4 is {0}", num3);
            Console.WriteLine("number5 is {0}", num4);
            Console.WriteLine("number6 is {0}", num5);
            Console.WriteLine("character is {0}", (int)ch);
            Console.WriteLine("string is ", days);

            Console.WriteLine("1,", Days.Tuesday); //aşağıda enum sabitlerinden aldı
            Console.WriteLine("2,", (int)Days.Tuesday); //tip dönüşümü, sıra no'sunu yazar

        }
    }
    enum Days // class dışında yazılır
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday //mondayin başlangıç değerni değiştiriyoruz burdan sırayla gider
            //10dan başlayıp 10,11,12,13 diye gider
            //hepsine ayrı ayrı da atayabilirsin monday:10 tuesday:20 ... gibi
    }


}