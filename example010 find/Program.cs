int [] array = {45,28,57,96,84,85,57,12,42,39};

int n = array.Length;
int find = 57;

int index = 0;

while(index<n)
{
    if(array [index]==find)
    {
        Console. WriteLine (index);
        break ;
    }
    //index=index+1;
    index++;
}