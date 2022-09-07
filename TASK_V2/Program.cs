// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

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


string[] FindString (string[] arr)
{
    string[] newArr = new string[arr.Length];
    int count = 0;

    foreach (string newString in arr) 
    {
        if (newString.Length <= 3) 
        {
            newArr[count] = newString;
            count++;
        }
    }
    return newArr;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} meets: {arr[i]}");
    Console.WriteLine();
}

Console.WriteLine ("How many elements, do you want to write? ");
int a = int.Parse(Console.ReadLine());

string[] newArray = FillArray(a);
string[] changedArray = FindString(newArray);

PrintArray(changedArray);
