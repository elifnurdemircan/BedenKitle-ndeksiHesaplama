// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.Write("Boyunuzu metre cinsinden giriniz: ");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kilonuzu kilogram cinsinden giriniz: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        double bmi = kilo / (boy * boy);

        Console.WriteLine($"Beden Kitle İndeksiniz: {bmi:F2}");


        if (bmi < 18.5)
        {
            Console.WriteLine("Kategori: Zayıf");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Kategori: Normal Kilolu");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Kategori: Kilolu");
        }
        else 
        {
            Console.WriteLine("Kategori: Obez");
        }
       
    }
}
