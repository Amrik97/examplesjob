int[] array = {1, 62, 53, 4, 18, 5, 36, 27, 18};

int n = array.Length;
int find = 1;

int index = 0;

while(index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}