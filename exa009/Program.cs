int Max(int arg1, int arg2, int arg3)

{
    int result = arg1;
    if (arg2> result) result = arg2;
    if( arg3>result) result =arg3;
    return result;
}
//              0  1  2   3  4 5  6   7  8  index
int[] array = {18,24,563,84,5,76,575,85,49};        // масив
// array[0] = 12;                                  как записать значение под индексом 0 присвоили 12


//Console.WriteLine(array[0]); Как вывести значение под индексом 0

int max = Max(
    Max(array[0],array[1], array[2]),
    Max(array[3],array[4], array[5]),
    Max(array[6],array[7], array[8])
    );
    Console.WriteLine(max);
    