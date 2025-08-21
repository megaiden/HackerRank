// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!: Minimum Swap");

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

int result = Result.MinimumSwaps(arr);
Console.WriteLine("result " + result);
class Result
{
    public static int MinimumSwaps(int[] arr)
    {
        if (IsAscending(arr))// Check if Array is already Ordered ASC
        {
            return 0;
        }

        var swapCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var iteration = FindMinValue(arr, i );
            if(iteration > 0) 
            {
                var temp = arr[iteration];
                arr[iteration] = arr[i];
                arr[i] = temp;
                swapCount += 1;
            }
        }

        return swapCount;
    }

    static int FindMinValue(int[] arr, int positionToLook)
    {
        var iteration = 0;
        int minValue = arr[positionToLook];
        for (int i = positionToLook; i < arr.Length; i++)
        {
            if (minValue > arr[i])
            {
                minValue = arr[i];
                iteration = i;
            }
        }

        return iteration;
    }
    static bool IsAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}


