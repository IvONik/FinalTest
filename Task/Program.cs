string[] array1 = new string[5] {"11", "23", "rock", "23432", "col"};
string[] array2 = new string[array1.Length];

fillNewArray(array1, array2);
PrintArray2 (array2);

void fillNewArray(string []array1, string []array2)
{
    int j=0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length<=3)
    {
        array2[j]=array1[i];
        j++;
    }
}
}
void PrintArray2 (string [] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write($"{array2[i]} ");
    }
}