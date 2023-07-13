int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 78;
int a2 = 66;
int a3 = 12;
int b1 = 78;
int b2 = 66;
int b3 = 12;
int c1 = 78;
int c2 = 6600;
int c3 = 12;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(b1, b2, b3);
// int max3 = Max(c1, c2, c3);
// int maxfin = Max(max1, max2, max3);

int maxfin = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(maxfin);
