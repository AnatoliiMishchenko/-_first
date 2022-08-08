
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
int [] array = new int[9]{15,14,17,1854,12,13,127,187,1472};
//array[0] = 15;
//Console.WriteLine(array[0]);


int max = Max(Max(array[0] ,array[1] ,array[3]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));


Console.WriteLine("Максимальное значение = " + max);