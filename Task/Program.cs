void PrintArray (string[] array)//Метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
string[] ReformArray (int count, string[] array)//Метод создания нового массива по условию
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            string current = array[j];
            if (current.Length <= count)
            {
                newArray[j] = current;
            }
        }
    }
    return newArray;
}
string[] ClearArray (string[] array)//Метод очистки нового массива от пустых элементов
{
    array = array.Where(x => x != null).ToArray();
    return array;
}
string[] array = {"LOL", "Hello", "Hi", "Best", "WTF"};
PrintArray(array);
Console.WriteLine();
string[] newArray = ReformArray(3, array);
string[] arrayClear = ClearArray(newArray);
PrintArray(arrayClear);
Console.WriteLine();
Console.WriteLine($"Длина массива - {arrayClear.Length}");


