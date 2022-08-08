int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
//int [] array = new int[9]{15,14,17,18,12,13,127,187,1472}
int a1 = 15;
int b1 = 14;
int c1 = 17;
int a2 = 18;
int b2 = 12;
int c2 = 13;
int a3 = 127;
int b3 = 187;
int c3 = 1472;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c3);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1,max2,max3:)
int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
Console.WriteLine("Максимальное значение = " + max);