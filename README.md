# URL Shortener

A simple URL shortener implementation in C#.

## Features
- Generates short URLs using Base62 encoding.
- Maps shortened URLs to original URLs.
- Provides access to the original URL using the shortened URL.

## Usage

```csharp
URLShortener urlShortener = new URLShortener();
string longURL1 = "https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Singleton/Singleton1.cs";
string longURL2 = "https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Builder/CarBuilder.cs";

string shortenURL1 = urlShortener.CreateShorten(longURL1);
string shortenURL2 = urlShortener.CreateShorten(longURL2);

Console.WriteLine(longURL1);
Console.WriteLine(shortenURL1);

Console.WriteLine("##############################");

Console.WriteLine(longURL2);
Console.WriteLine(shortenURL2);

Console.WriteLine("################################");

Console.WriteLine(urlShortener.Access(shortenURL1));
Console.WriteLine(urlShortener.Access(shortenURL2));
```

## Example Output
```
https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Singleton/Singleton1.cs
https://shorten.com/U0q

##############################

https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Builder/CarBuilder.cs
https://shorten.com/V0q

################################

https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Singleton/Singleton1.cs
https://github.com/ravikumarmakwana/DesignPatterns/blob/master/DesignPatterns/Creational/Builder/CarBuilder.cs
```

