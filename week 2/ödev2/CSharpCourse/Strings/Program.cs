namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        //Intro();

        string sentence = "my name is engin demiroğ";
        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "my name is derin demiroğ";

        bool result3 = sentence.EndsWith("Ğ"); //küçük büyük karakter hassasiyeti var!
        bool result4 = sentence.StartsWith("My name");

        var result5 = sentence.IndexOf("namee"); // bulamazsa -1 döndürür!
        var result6 = sentence.IndexOf(" "); // bulduğu ilk karakteri döndürür!
        var result7 = sentence.LastIndexOf(" "); // aramaya sondan başlar!
        var result8 = sentence.Insert(0, "Hello, ");
        var result9 = sentence.Substring(3,4); // 3ten itibaren 4 tane al
        var result10 = sentence.ToLower(); // bütün karakterleri küçültür!
        var result11 = sentence.ToUpper(); // bütün karakterleri büyütür!
        var result12 = sentence.Replace(" ", "-");
        var result13 = sentence.Remove(2,3); //index 2den itibaren 3 tanesini sil!

        Console.WriteLine(result13);

        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "ankara";
        //Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "istanbul";
        //string result = city + city2;
        //Console.WriteLine(result);
        
        Console.WriteLine(String.Format("{0} {1}",city ,city2));
    }
}