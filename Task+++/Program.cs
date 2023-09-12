// 

void Walk(DirectoryInfo root)
{
// Получаем все файлы в текущем каталоге
FileInfo[] files = root.GetFiles("*.*");

if (files != null)
{
//выводим имена файлов в консоль
foreach (FileInfo file in files)
Console.WriteLine(file.FullName);

//получаем все подкаталоги
DirectoryInfo[] subDirs = root.GetDirectories();
//проходим по каждому подкаталогу
foreach (DirectoryInfo dirInfo in subDirs)
//рекурсия
Walk(dirInfo);
}
}
//задаем папку для обхода
string rootDir = @"c:\Users\tdv12\OneDrive\Документы\C_Sharp\Selection_Sort";
//вызываем рекурсивный метод
Walk(new DirectoryInfo(rootDir));