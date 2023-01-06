namespace AlgorythmsExam;

public class ShellSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;
        for (int d = n / 2; d > 0; d /= 2)
        {
            for (int i = d; i < n; i++)
            {
                for (int j = i - d; j >= 0 && array[j] > array[j + d]; j -= d)
                {
                    (array[j], array[j + d]) = (array[j + d], array[j]);
                }
            }
        }
    }
}