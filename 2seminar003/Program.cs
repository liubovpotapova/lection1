// Максимальное из 3 и более
int [] array = {1,9,18,8};
int length = array.Length;
int index = 0;
int max=0;

while (index<length)
{
    if (array[index]>max) max=array[index];
    index++;

}

Console.WriteLine (max);