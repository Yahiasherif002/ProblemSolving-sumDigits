internal class Program
{
    static void sumArray(int[] arr)
    {
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        string[] arrItems = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(arrItems[i]);
        }
        sumArray(arr);
    }
}