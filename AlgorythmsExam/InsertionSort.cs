namespace AlgorythmsExam;

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        for(int i=1; i < array.Length; i++)
        {
            int k = array[i]; //cheked element
            int j = i - 1; //prev checked element

            while(j>=0 && array[j] > k)
            {
                array[j + 1] = array[j]; //swap next element
                array[j] = k; //return value array[j]
                j--;
            }
        }
    }
}