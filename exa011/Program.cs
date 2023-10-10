void FillArray(int[] collection)  //  метод который рандомно задает масив из указоной длины next 
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] col) // метод печати масив
{
    int count = col.Length;
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine ( col[position] );
        position++;
    } 
}

int IndexOf (int[] collection, int find)
                                          // метод IndexOf который испльзует (масив  метода FillArray) для нахождения позиции Pos заданого числа find и выводит его
{
    int count = collection.Length;
    int index = 0;
    int position = -1;                     // -1 если искомого элемента нет в масиве -1 указывает на это.
    while (index < count)
    {
        if(collection[ index ] == find)
        {
            position = index;
            break;
        }
        index++; 
    }
        return position;
 }

int [] array = new int [10];                  // создай новый масив в котором будет 10 элементов(может быть любое количество) 
                                              //для его  заполнения ипользуется метод Который мы создали  FillArray

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf (array,4);
Console.WriteLine(pos);