string path = @"C:\Example";
string subfolder1 = @"\Subfolder1";
string subfolder2 = @"\Subfolder2";

if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}
Directory.CreateDirectory($"{path}/{subfolder1}");
Console.WriteLine("Каталог C:\\Example\Subfolder1 создан");

Directory.CreateDirectory($"{path}/{subfolder2}");
Console.WriteLine("Каталог C:\\Example\Subfolder2 создан");

if (Directory.Exists(path))
{
    Directory.Delete(path, true);
    Console.WriteLine("Каталог C:\\Example удален");
}
else
{
    Console.WriteLine("Каталог не существует");
}
