/*Console.Write("Введите слово: ");
string word = Console.ReadLine().ToLower(); 

int count = 0;


foreach (char c in word)
{
    if (c == 'а') 
    {
        count++;
    }
}

Console.WriteLine($"Буква 'а' встречается {count} раз(а).");*/
//Задание 2
/*Console.Write("Имя файла: ");
string fileName = Console.ReadLine();
if (fileName.EndsWith(".cs"))
{
    Console.WriteLine("Это файл C#");
}
else if (fileName.EndsWith(".png") || fileName.EndsWith(".jpg"))
{
    Console.WriteLine("Это изображение");
}
else
{
    Console.WriteLine("Неизвестный тип");
}
if (fileName.StartsWith("Lab"))
{
    Console.WriteLine("Это лабораторная работа");
}
if (fileName.Contains("test"))
{
    Console.WriteLine("Тестовый файл");
}*/
//Задание 3
/*Console.Write("Введите фразу: ");
string answer = Console.ReadLine();
Console.WriteLine(answer.ToUpper());
foreach (char c in answer)
{
    if (c == ' ')
    {
        Console.Write('_');
    }
    else
    {
        Console.Write(c);
    }
}
Console.WriteLine();
string a = answer.ToLower();
if (a.EndsWith("стоп"))
{
    Console.WriteLine("Стоп-слово найдено!");
}
else if (a.StartsWith("стоп"))
{
    Console.WriteLine("Стоп-слово найдено!");
}
else 
{
    Console.WriteLine("Стоп-слово найдено!");
}*/
// Задание 4
/*Console.Write("Введите дату : ");
string date = Console.ReadLine(); 
string year = date.Substring(0, 4);
string month = date.Substring(5, 2);
string day = date.Substring(8, 2);
Console.WriteLine($"{day}.{month}.{year}");
Console.Write("Введите телефон (11 цифр): ");
string phone = Console.ReadLine(); 
string code = phone.Substring(1, 3);
string p1 = phone.Substring(4, 3);
string p2 = phone.Substring(7, 2);   
string p3 = phone.Substring(9, 2);   
Console.WriteLine($"+7 ({code}) {p1}-{p2}-{p3}");*/
//Задание 5
/*Console.Write("Введите строку: ");
string text = Console.ReadLine();
int b = 0;      
int count = 0;  
string kro = "аеёиоуыэюя";
foreach (char c in text) 
{
    if (c == ' ') 
    {
        b++;
    }

    if (kro.Contains(char.ToLower(c))) 
    {
        count++;
    }
}
Console.WriteLine($"Количество символов: {text.Length}");
Console.WriteLine($"Количество пробелов: {b}");
Console.WriteLine($"Количество гласных: {count}");*/
//Задание 6
/*Console.WriteLine("Введите слово: ");
string s = Console.ReadLine();

string r = "";
for (int i = s.Length - 1; i >= 0; i--)
{
    r += s[i];
}

Console.WriteLine($"Перевёртыш: {r}");

if (s.ToLower() == r.ToLower())
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром.");
}*/
//Итоговая задача

Console.WriteLine("Введите email: ");
string s = Console.ReadLine();

if (s.Length < 5)
{
    Console.WriteLine("Адрес некорректен: длина меньше 5 символов");
}
else
{
    int c = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '@') c++;
    }

    if (c == 1)
    {
        if (s.StartsWith("@") || s.EndsWith("@"))
        {
            Console.WriteLine("Адрес некорректен: начинается или заканчивается на @");
        }
        else if (s.Contains(" "))
        {
            Console.WriteLine("Адрес некорректен: содержит пробелы");
        }
        else if (s.ToLower().EndsWith(".ru") || s.ToLower().EndsWith(".com"))
        {
            Console.WriteLine($"Адрес корректен: {s.ToLower()}");
        }
        else
        {
            Console.WriteLine("Адрес некорректен: должен заканчиваться на .ru или .com");
        }
    }
    else
    {
        Console.WriteLine("Адрес некорректен: должен быть ровно один @");
    }
}
//ДОП задание
/*using System.Text;

Console.WriteLine("Введите строку: ");
string s = Console.ReadLine();

string gl = "аеёиоуыэюя";
StringBuilder sb = new StringBuilder();

for (int i = 0; i < s.Length; i++)
{
    string c = s[i].ToString().ToLower();
    if (gl.Contains(c) == false)
    {
        sb.Append(s[i]);
    }
}

Console.WriteLine(sb.ToString());*/