using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("123456", "Nokia X", "111222333444", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("789101", "iPhone 13", "555666777888", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}