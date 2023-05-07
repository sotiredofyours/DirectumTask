namespace DirectumTask;

using System.Text;

public class TextGenerator
{
    
    private readonly char[] _separators = {' ', '.', ',', '!', '?', ';'};
    private readonly List<string> _dictionary;
    private readonly Random _rnd;

    public TextGenerator(List<string> dictionary)
    {
        _dictionary = dictionary;
        _rnd = new Random();
    }
    
    private char PickSeparator()
    {
        return _separators[_rnd.Next(_separators.Length)];
    }

    private string PickWord()
    {
        return _dictionary[_rnd.Next(_dictionary.Count)];
    }
    
    public string GenerateText(int minWords, int maxWords)
    {
        var rnd = new Random();
        var wordsCount = rnd.Next(minWords, maxWords);
        var text = new StringBuilder();
        for (int i = 0; i < wordsCount; i++)
        {
            text.Append(PickWord());
            text.Append(PickSeparator());
            text.Append(' ');
        }

        return text.ToString();
    }
}
