# Генератор DOCX-файлов
___
### Подготовка к запуску
Убедитесь, что у вас установлены необходимые компоненты
- .NET 7.0 

### 1. Клонирование репоризтория
``git clone https://github.com/sotiredofyours/DirectumTask``

### 2. Установка зависимостей

В корневой папке проекта:

``dotnet restore``

``dotnet restore-tools``

### 3. Запуск

В корневой папке проекта:

``dotnet run --project DirectumTask``

## Настройки программы
Любые настройки производятся путем изменения `App.config` в папке проекта.

Программа поддерживает несколько видов настроек:
- Максимальное и минимальное количество слов в генерируем файле - `MinWordsInDocument`, `MaxWordsInDocument`
- Папка, в которую будут генерироваться файлы - `OutputPath`. 
Можно указать абсолютный путь, например `"C:/"`, или относительный от рабочего каталога программы - `../../`.
- Количество документов, которое будет сгенерировано - `DocumentCount`

### Пример:
`````<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <appSettings>
        <add key="MinWordsInDocument" value="10" />
        <add key="MaxWordsInDocument" value="100" />
        <add key="DocumentCount" value="10" />
        <add key="OutputPath" value="C:/" />
    </appSettings>
</configuration>
`````

## Использованные библиотеки и инструменты:
- [DocX][docx]

- [Словарь русских слов][dict] 

[docx]:https://github.com/xceedsoftware/DocX
[dict]:https://dim-studio.ru/seo/xrumer/178-baza-russkih-slov-371-000-slov.html
