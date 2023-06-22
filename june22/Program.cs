internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        int[] number = {100, 31, 4, 13, 78, 56, 37, 76};
        for (int i=0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
        }
        selectionsort(number);
        foreach (char digit in number)
        {
            Console.WriteLine(digit);
        }

        Console.ReadKey();
    }
    private static void selectionsort(int[] number)
    {
        for(int i=0; i < number.Length; i++)
        {
            int min = i;
            for (int j=0; j<number.Length; j++)
            {
                if (number[min] > number[j])
                {
                    min = j;
                }
            } ;
            int temp = number[i];
            number[i] = number[min];
            number[min] = temp;
        }
    }
}