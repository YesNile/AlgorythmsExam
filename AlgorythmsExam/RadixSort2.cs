namespace AlgorythmsExam;

public class RadixSort2
{
    static int[] GetArr(Dictionary<int, List<int>> table)
    {
        var list = new List<int>();
        for (var i = -9; i <= 9; i++)
        {
            foreach (var item in table[i])
            {
                list.Add(item);
            }

            table[i] = new List<int>();
        }

        return list.ToArray();
    }

    public static int[] Sort(int[] array)
    {

        var maxlenght = 1;
        foreach (var item in array)
        {
            var lenght = (int) Math.Log10(item) + 1;
            if (lenght > maxlenght)
            {
                maxlenght = lenght;
            }
        }

        var table = new Dictionary<int, List<int>>();
        for (var i =-9; i <= 9; i++)
        {
            table.Add(i, new List<int>());
        }

        var mul = 1;
        for (var k = 0; k < maxlenght; k++)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var key = array[i] / mul % 10;
                table[key].Add(array[i]);
            }

            mul *= 10;
            array = GetArr(table);
        }

        return array;
    }
}