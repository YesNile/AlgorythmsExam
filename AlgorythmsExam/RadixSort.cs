namespace AlgorythmsExam;
//Поразрядная сортировка.Сложность O(k * n), где k количество проходов по массиву.
public class RadixSort
{
    public static void Sort(int[] array)
    {
        int i, j;
        int[] tmp = new int[array.Length];
        for (int shift = sizeof(int) * 8 - 1; shift >= 0; shift--)
        {
            j = 0;
            for (i = 0; i < array.Length; i++)
            {
                var before = Convert.ToString(array[i], toBase: 2);
                var a = array[i] << shift;
                var after = Convert.ToString(a, toBase: 2);
                bool move = (a) >= 0;
                if (shift == 0 ? !move : move)
                    array[i - j] = array[i];
                else
                    tmp[j++] = array[i];
            }
            Array.Copy(tmp, 0, array, array.Length - j, j);
        }
    }
}