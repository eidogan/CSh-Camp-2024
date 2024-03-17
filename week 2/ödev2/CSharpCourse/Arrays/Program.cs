namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        //string[] students = new string[3];
        //students[0] = "engin";
        //students[1] = "derin";
        //students[2] = "salih";

        //string[] students2 = { "engin", "derin", "salih" };

        //foreach (var student in students)
        //{
        //    Console.WriteLine(student);
        //}

        string[,] regions = new string[3, 3]
        {
            { "istanbul", "izmit", "balıkesir" },
            { "ankara", "konya", "kırıkkale" },
            { "antalya", "adana", "mersin" }
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++) //satırları(0) gezmek için
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++) //sütunları(1) gezmek için
            {
                Console.WriteLine(regions[i,j]);
                
            }
            Console.WriteLine("***********");

        }

        Console.WriteLine();
        Console.ReadLine();
    }
}