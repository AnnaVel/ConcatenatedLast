internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<int> results = new List<int>() { 1, 2, 3 }.Concat(new List<int>()).Concat(new List<int>());

        bool any = results.Any(); // true
        int count = results.Count(); // 3
        int last = results.Last(); // 'Sequence contains no elements.'
    }
}