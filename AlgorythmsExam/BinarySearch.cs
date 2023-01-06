namespace AlgorythmsExam;

public class BinarySearch
{
    public static int Search(int[] array, int value, int min, int max)
    {
        int mid = min+ (max-min) / 2;
        if (min>max)
        {
            return -1;
        }

        if (array[mid] < value)
        {
            return Search(array, value, mid + 1, max);
        }
        else if (array[mid] > value)
        {
            return Search(array, value, min, mid - 1);
        }

        return mid;
    }
}