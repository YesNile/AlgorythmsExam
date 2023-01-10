namespace AlgorythmsExam;
// Сортировка выбором. Сложность O(n^2). Наименьший элемент перемещается в отсортированную последовательность
public class SelectionSort
{
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            (array[i], array[min]) = (array[min], array[i]);
        }
    }
}