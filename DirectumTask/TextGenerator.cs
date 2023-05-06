namespace DirectumTask;

using System.Text;

public class TextGenerator
{
    
    private readonly char[] _separators = {' ', '.', ',', '!', '?', ';'};
    private readonly List<string> _dictionary;

    public TextGenerator(List<string> dictionary)
    {
        _dictionary = dictionary;
    }
    
    private char PickSeparator()
    {
        return _separators[new Random().Next(_separators.Length)];
    }

    private string PickWord()
    {
        return _dictionary[new Random().Next(_dictionary.Count)];
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