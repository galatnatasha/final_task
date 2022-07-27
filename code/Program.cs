void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


string [] array = {"hellow", "2", "world", ":-)"};
string [] array2 = new string [array.Length];
int index2 = 0;

for (int index = 0; index < array.Length; index++)
{
    if (array[index].Length <= 3)
    {
        array2[index2] = array[index];
        index2++;
    }
}
PrintArray(array2);
