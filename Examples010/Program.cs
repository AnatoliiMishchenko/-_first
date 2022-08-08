int[] array = { 1, 1, 2, 3, 4, 4, 6, 7, 4, 354, 4324 };
int n = array.Length;
int find = 40;
int count = 0;

while (count < n)
{
    if (array[count] == find)
    {
        Console.WriteLine(count);
        break;
    }
    count++;
}
Console.WriteLine("Значение не наидено");