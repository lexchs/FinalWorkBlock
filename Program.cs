string[] original = new string[4] {"Hello", "2", "world", ":-)"};
string[] newArray = new string[original.Length];

void ArrayInput(string[] original, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < original.Length; i++)
    {
        if (original[i].Length <= 3)
        {
            newArray[count] = original[i];
            count++;
        }
    }
}

void PrintNew(string[] array)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
}

ArrayInput(original, newArray);
PrintNew(newArray);