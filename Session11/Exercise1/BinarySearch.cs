using System;

public class BinarySearch
{
    public static int Search(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (arr[middle] == x)
            {
                return middle;
            }
            else if (arr[middle] < x)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}