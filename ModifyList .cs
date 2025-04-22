public static class MyList
{
    public static List<int> ModifyList(this List<int> list, Predicate<int> predicate)
    {
        var list1 = new List<int>();
        for (int i=0; i<list.Count; i ++)
        {
            if (predicate.Invoke(list[i]))
            {
                list1.Add(list[i]);
            }
        }
        return list1;
    }
}

class Program {
    static void Main(string[] args)
    {
        var list = new List<int> { 1, 2, 8, 4, 0, 9, 3, 6, 5, 21, 12 };
        list = list.ModifyList(x => x % 3 == 0);
        Console.WriteLine(string.Join(", ", list));
    }
}
