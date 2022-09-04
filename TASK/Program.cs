// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

string[] NewString (string[] array)
{
    string[] changedArray = new string [array.Length];
    int j = 0;
    for (int i=0; i<array.Length; i++)
    {
            if (array[i].Length <= 3)
            {
                changedArray[i] = array[i];
                j++;
            }
    }
    return changedArray;
}

string[] FillArray (int count)
{
    string[] newArray = new string[count];
    for (int i=0; i<count; i++)
    {
        Console.WriteLine ("Write text: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void PrintArray (string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write ($" {array[i]} ");
    }
}


Console.WriteLine ("How many elements, do you want to write? ");
int a = int.Parse(Console.ReadLine());

string[] newArray = FillArray(a);
string[] changedArray = NewString(newArray);

PrintArray(changedArray);
