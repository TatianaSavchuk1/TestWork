//Написать программу, которая тз имеющегося массива строк формирует иассив из строк, длина которых меньше либо равна 3 символа.

string[] array = new string[5] {"hello", "5", "world", "hi", "924"};
string[] finalArray = new string[array.Length];


void ShortStringsArray(string[] array, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        finalArray[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
ShortStringsArray(array, finalArray);
PrintArray(finalArray);
