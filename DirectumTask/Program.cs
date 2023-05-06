using DirectumTask;

Console.WriteLine("Получаю настройки...");
var settings = SettingsParser.GetSettings();
await new DocxGenerator().GenerateFiles(settings);
Console.WriteLine("Выполнено.");