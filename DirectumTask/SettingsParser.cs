using System.Configuration;

namespace DirectumTask;

public static class SettingsParser
{

    private const string MaxWords = "maxWordsInDocument";
    private const string MinWords = "minWordsInDocument";
    private const string NumberOfDocuments = "documentCount";
    private const string Path = "OutputPath";
    
    public static Settings GetSettings()
    { 
        if (ConfigurationManager.AppSettings.Count < 3)
            throw new ConfigurationErrorsException("Не указана часть необходимых настроек.");

        var path = ConfigurationManager.AppSettings.Get(Path);
        
        int.TryParse(ConfigurationManager.AppSettings.Get(MinWords), out var minWords);
        int.TryParse(ConfigurationManager.AppSettings.Get(MaxWords), out var maxWords);
        int.TryParse(ConfigurationManager.AppSettings.Get(NumberOfDocuments), out var docCount);

        if (minWords < 0 || maxWords < 0 || docCount < 0)
            throw new ConfigurationErrorsException("Неверные настройки, все значения должны быть больше нуля");
        
        
        path ??= Environment.CurrentDirectory; // если не указано в настройках, файлы будут генерироваться в рабочей папке проекта 
        
        if (minWords > maxWords)
            throw new ConfigurationErrorsException("Неверные настройки, минимальное кол-во слов должно быть меньше минимального.");
        
        return new Settings
        {
            Path = path,
            MaxWords = maxWords,
            MinWords = minWords,
            NumberOfFiles = docCount
        };
    }
}