void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
string[] ReformArray (int count, string[] array)
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
string[] array = {"LOL", "Hello", "Hi", "Best", "WTF"};
PrintArray(array);
Console.WriteLine();
string[] newArray = ReformArray(3, array);
PrintArray(newArray);


