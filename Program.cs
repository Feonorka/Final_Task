Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string[num];





void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArray(array);
array = CreateArrayStr(num, RandomNum(0, 5), RandomNum(0,5));
PrintArray(array);


// Генерация случайной строки
string RandomString(int length)
        {
            var result = new char[length];
            var r = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                do
                    result[i] = (char) r.Next(100); 
                while (result[i] < '!');
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


string[] CreateArrayStr(int size, int min, int max)
{
    string[] array = new string[size];
    int len = RandomNum(0, 10);
    for (int i = 0; i < size; i++)
    {
        array[i] = RandomString(len);
    }
    return array;
}
