namespace AlgorythmsExam;

public class ShakerSort
{
    public static void Sort(int[] array)
    {
        int left = 0,
            right = array.Length - 1,
            count = 0;

        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                count++;
                if (array[i] > array[i + 1])
                    (array[i], array[i+1]) = (array[i+1], array[i]);
            }

            right--;

            for (int i = right; i > left; i--)
            {
                count++;
                if (array[i - 1] > array[i])
                    (array[i], array[i-1]) = (array[i-1], array[i]);
            }

            left++;
        }
    }
}