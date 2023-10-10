int [] array = {1,52,6,3,32,2,36,889,54,32,588,};

int n = array.Length; // array.Length определение длины массива
int find =32;

int index = 0;

while(index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;                       //   break; если условия выполнились и найден индекс finde(32), последующий индекс с таким же Finde(32), 
                                     //будет прерван (будет отображатся только первый) найденый индекс.
    }
    index++;
}