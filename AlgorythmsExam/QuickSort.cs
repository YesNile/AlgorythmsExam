namespace AlgorythmsExam;
// Быстрая сортировка. O(n*log2 n). Массив разбивается на левый и правый от опорного элемента
public class QuickSort
{
    public static int[] QSort(int[] array,int min,int max)
    { 
        if ( min >= max)
                 return array;
             
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
            return market;
        }
       
        var pivot = Sort(array, min, max);
        QSort (array, min, pivot-1);
        QSort (array, pivot+1, max);
        return array;
    }
}