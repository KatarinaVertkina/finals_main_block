string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int g = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[g] = array1[i];
        g++;
        }
    }
}   
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);
