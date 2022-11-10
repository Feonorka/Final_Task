int num = default;
string[] array = new string[num];

// Формирование нового массива, удовлетворяющего условиям
string[] FormatingArr(string[] arr)
{
    string[] array = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    array[i] = arr[i];
                }
                else
                    array[i] = "";
            }
        return array;
}
// Вывод массива в консоль
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "")
        {
            if (i < array.Length - 1) Console.Write($"{array[i], 4}, ");
            else Console.Write($"{array[i], 4}");
        }
    }
    Console.WriteLine("]");
}
// Генерация случайной строки
string RandomString(int length)
        {
            var result = new char[length];
            var r = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                do
                    result[i] = (char) r.Next(100); 
                while (result[i] < '&');
            }
            return new string(result);
        }
// Генерация случайного числа для задания длины случайной строки
int RandomNum(int min, int max)
{
    int num = default;
    num = new Random().Next(min, max);
    return num;
}
// Создание строкового массива
string[] CreateArrayStr(int size)
    {
        string[] array = new string[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = RandomString(RandomNum(1, 11));
            }
        return array;
    }


string[] OrignArray = CreateArrayStr(RandomNum(5, 11));
Console.WriteLine("Оригинальный массив:");
PrintArray(OrignArray);
string[] FormaArray = FormatingArr(OrignArray);
Console.WriteLine("Форматированный массив:");
PrintArray(FormaArray);