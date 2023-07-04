using ConsoleApp9;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        //Завдання 1/3
        using (Piece piece = new Piece("Чорна Пантера i Бiлий Медвiдь",
            "Володимир Винниченко", "Драма", 1911))
        {
            piece.DisplayInformation();
            piece.Title = "Три плюс два";
            piece.Author = "Олександр Iрванець";
            piece.Year = 2021;
            piece.DisplayInformation();
        }
        Console.WriteLine("Очищено!");
        Console.WriteLine();
        //Завдання 2/3
        using (Shop shop = new Shop("Арсен", "Iвана Миколайчука, 2", "Продовольчий"))
        {
            shop.DisplayInformation();
            Console.WriteLine();
            shop.ShopType = "Продовольчi та побутовi товари";
            shop.DisplayInformation();
        }
        //Завдання 3 додаток до 2завдання
        Console.WriteLine();
        Shop shop2 = new Shop("ТРЦ \"Велес\"", "Вовчинецька, 225а", "Продовольчi та побутовi товари");
        shop2.DisplayInformation();
        shop2.Dispose();
        Console.WriteLine("\"Очищено!\"");
    }
}
