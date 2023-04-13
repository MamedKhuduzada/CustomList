internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> list = new MyList<string>();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        list.Add("x");
        list.Add("z");
        list.Add("s");
        Console.WriteLine(list.IndexOf("b"));
    }
}
class MyList <T>
    where T : class
{
    private T[] arr=new T[0];
    private int Count { get; set; }
    private int Capacity;

    public void Add(T item)
    {
        if (Count == 0)
        {
            arr = new T[4];
            arr[Count++] = item;
        }
        else if(Count==arr.Length)
        {
            Array.Resize(ref arr, arr.Length * 2);
            arr[Count++] = item;   
        }
        else
        {
            arr[Count++] = item;
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < Count ; i++)
        {
            if (arr[i] == item)
            {
                return i;
            }
        }
        return -1;
    }


    public void RemoveAt(T item)
    {
        int index = IndexOf(item);
        T[] newArray = new T[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (index != i)
            {
                newArray[j++] = arr[i];
            }
        }
        arr = newArray;
    }
}