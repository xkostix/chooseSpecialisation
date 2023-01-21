//Программа из массива строк формирует массив из строк, длина которых не более 3 символов.

void getArrayOfThreeChar();

string[] originArray = new string["1234", "yes", "nono", "22", "54321"]; // Исходные данные

string[] resultArray;
int j = 0;

//Поиск нужных строк и Формирование итогового массива
for (int i = 0; i < originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
    {
        resultArray[j] = originArray[i];
        j++;
    }
}

