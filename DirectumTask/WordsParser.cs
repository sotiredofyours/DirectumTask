using System.Text;

namespace DirectumTask;

public static class WordsParser
{
    public static async Task<List<string>> GetAllWords()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "RUS.TXT");
        using var reader = new StreamReader(path, Encoding.UTF8);
        var text = await reader.ReadToEndAsync();
        return text.Split("\n").Select( str => str.Trim('\r')).ToList();
    }
}