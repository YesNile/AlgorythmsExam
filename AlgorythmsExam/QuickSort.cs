namespace AlgorythmsExam;

public class QuickSort
{
    public static int[] QSort(int[] array,int first,int last)
    {
        static int Sort(int[] array,int first,int last)
        {
            var market = first;
            var pivot = array[last];//pivot выбирается различными способами в данной реализации я вязл его как последний элемент
            for (var i = first; i < last; i++)
            {
                if (array[i] < pivot)
                {
                    (array[market], array[i]) = (array[i], array[market]);
                    market++;
                }
            }
            (array[market], array[last]) = (array[last], array[market]);
            // foreach (var value in array)
            // {
            //     Console.Write(value+" ");
            // }
            // Console.WriteLine();
            return market;
        }
        if ( first >= last)
            return array;
        
        var pivot = Sort(array, first, last);
        QSort (array, first, pivot-1);
        QSort (array, pivot+1, last);
        return array;
    }
}