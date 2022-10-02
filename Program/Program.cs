void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

string[] CreateArray(int size)
{
    string[] array = new string[size];
    Console.WriteLine("Input array, use <,>, as delimiter for each element");
    string word = Console.ReadLine();
    array = word.Split(",");
    return array;
}

string[] CreateSmallArray(string[] array, int size)
{
    int counter = 0;
    string[] arraySmall = new string[size];
    for (int i = 0; i < size; i++)
    {
        if(i <= 3)
        {
            arraySmall[counter] = array[i];
            counter++;
        }
    }
    return arraySmall;

}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int sizeSmallArray = 3;
string[] newArray = CreateArray(size);
string[] arraySmall = CreateSmallArray(newArray, sizeSmallArray);
ShowArray(arraySmall);