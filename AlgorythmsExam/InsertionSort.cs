namespace AlgorythmsExam;

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        for(int i=1; i < array.Length; i++)
        {
            int k = array[i];
            int j = i - 1;

            while(j>=0 && array[j] > k)
            {
                array[j + 1] = array[j];
                array[j] = k;
                j--;
            }
        }
    }
}