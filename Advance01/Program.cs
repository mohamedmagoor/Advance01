namespace Advance01
{
    internal class Program
    {
        static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }

            }
        }


        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            ///1
            int[] arr = { 5, 2, 9, 1, 7, 6 };
            Console.WriteLine("the array before sorting =>...");
            PrintArray(arr);
            OptimizedBubbleSort(arr);
            Console.WriteLine(" array after  =>  ");
            PrintArray(arr);


            //last section implement

            var intRange = new Range<int>(1, 10);
            Console.WriteLine("Int Range:");
            Console.WriteLine($"Contains 5: {intRange.Contains(5)}"); 
            Console.WriteLine($"Contains 15: {intRange.Contains(15)}"); 
        }


    }
}