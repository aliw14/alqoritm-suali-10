namespace alqoritm_suali_10;
class Program
{
    static void Main(string[] args)
    {
        int min = 0;
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[min])
                min = i;

        }Console.WriteLine(min);


    }
}

