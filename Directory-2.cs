string file = @"C:\Example\Subfolder1\test1.txt";
string text = "Hello, World!";

using (File.Create(file)) { }
File.WriteAllText(file, text);

static void AppendContent(string file, string content)
{
    try
    {
        File.AppendAllText(file,  content + "\n");
        Console.WriteLine("Строка добавлена в файл");
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    
}
static void ReadContent(string file)
{ 
    Console.WriteLine(File.ReadAllText(file));
}

static void ReadContentLine(string file)
{
    string[] line = File.ReadAllLines(file);
    for (int i = 0; i < line.Length; i++)
    {
        Console.WriteLine($"{i+1}: {line[i]}");
    }
}
static void FileCopy(string sourceFileName, string destFileName)
{
    try
    {
        File.Copy(sourceFileName, destFileName, true);
        Console.WriteLine("Файл скопирован");
    }
    catch (Exception ex) 
    { 
        Console.WriteLine($"Ошибка при копировании: {ex.Message}");
    }
}
static void FileMove(string sourceFileName, string destFileName)
{
    try
    {
        File.Move(sourceFileName, destFileName);
        Console.WriteLine("Файл перемещен");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка при копировании: {ex.Message}");

    }
}

AppendContent(file, "\nПривет, Мир!");
AppendContent(file, "Пока, Мир!");
ReadContent(file);
ReadContentLine(file);
FileCopy(file, @"C:\Example\Subfolder2\test2");
FileMove(file, @"C:\Example\Subfolder2\test1");
