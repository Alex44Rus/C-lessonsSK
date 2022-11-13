int Max(int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {10,24,13,54,45,688,574,800,9999999};
int max = Max(array[0], array[1], array[2],
              array[3], array[4], array[5],
               array[6], array[7], array[8]);

//int max = Max(max1, max2, max3);


Console.WriteLine(max);