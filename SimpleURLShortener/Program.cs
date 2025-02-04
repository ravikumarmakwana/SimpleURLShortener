public class Program
{
    public static void Main(string[] args)
    {
        URLShortener uRLShortener = new URLShortener();
        string longURL1 = "https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Singleton/Singleton1.cs";
        string longURL2 = "https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Builder/CarBuilder.cs";
        string shortenURL1 = uRLShortener.CreateShorten(longURL1);
        string shortenURL2 = uRLShortener.CreateShorten(longURL2);

        Console.WriteLine(longURL1);
        Console.WriteLine(shortenURL1);

        Console.WriteLine("##############################");

        Console.WriteLine(longURL2);
        Console.WriteLine(shortenURL2);

        Console.WriteLine("################################");

        Console.WriteLine(uRLShortener.Access(shortenURL1));
        Console.WriteLine(uRLShortener.Access(shortenURL2));
    }
}
