internal class Program
{
  
    private static void Main(string[] args)
    {
        
            int n = int.Parse(Console.ReadLine());
            string digits = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int digit = digits[i] - '0'; // Convert the character to an integer
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }

