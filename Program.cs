//Программа из массива строк формирует массив из строк, длина которых не более 3 символов.

string[] originArray = { "1111", "yes", "nono", "22", "54321" }; // Исходные данные

//Поиск количества нужных элементов
int j = 0;
for (int i = 0; i < originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
    {
        j++;
    }
}

string[] resultArray = new string[j];

//Поиск нужных строк и Формирование итогового массива
j = 0;
for (int i = 0; i < originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
    {
        resultArray[j] = originArray[i];
        j++;
    }
}

//Вывод итогового массива
Console.Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]} ");
}
Console.WriteLine("]");