//Обнуление массива
int [] a; //описание массива
a = new int[10];//создание массива
int i;

//the first way
i=0;
while (i<10)
{
    a[i]=0;
    ++i;
}
//the second way
for(int j=0;j<10;++j)
{
    a[j]=0;
}

for( i=0; i<10; ++i)//i is defined not in cycle
{
    Console.WriteLine (a[i]);
}

//Ввод массива с клавиатуры
for (int j=0; j<10; ++j)
{
    string s=Console.ReadLine ();
    a[j]=Convert.ToInt32(s);
}

for( i=0; i<10; ++i)//i is defined not in cycle
{
    Console.WriteLine (a[i]+" ");
}


