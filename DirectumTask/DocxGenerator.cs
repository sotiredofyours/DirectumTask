
using Xceed.Words.NET;

namespace DirectumTask;

public class DocxGenerator
{
    private int _id = 0; 
    private void GenerateSingleFile(string text, string path)
    {
        var doc = DocX.Create(Path.Combine(path, $"Generated{_id++}"));
        doc.InsertParagraph(text);
        doc.Save();
    }

    public async Task GenerateFiles(Settings settings)
    {
        var dict  = await WordsParser.GetAllWords();
        var textGenerator = new TextGenerator(dict);
        for (var i = 0; i < settings.NumberOfFiles; i++)
        {
            var text = textGenerator.GenerateText(settings.MinWords, settings.MaxWords);
            GenerateSingleFile(text, settings.Path);
            Console.WriteLine($"{i+1}/{settings.NumberOfFiles} Сгенерировано...");
        }
    }
}
