using System.Text;

public class URLShortener
{
    private static readonly Dictionary<string, string> _urlDictionary = new();
    private static long _counter = 100000;
    private const string _base62Char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private static string EncodeBase62(long num)
    {
        StringBuilder sb = new();
        while (num > 0)
        {
            sb.Append(_base62Char[(int)(num % 62)]);
            num /= 62;
        }
        return sb.ToString();
    }

    public string CreateShorten(string longURL)
    {
        string shortenURL = $"https://shorten.com/{EncodeBase62(_counter)}";
        _counter++;

        _urlDictionary[shortenURL] = longURL;
        return shortenURL;
    }

    public string Access(string shortenURL)
    {
        if (_urlDictionary.ContainsKey(shortenURL))
        {
            return _urlDictionary[shortenURL];
        }
        throw new InvalidOperationException("Given Shorten URL expired or invalid.");
    }

}