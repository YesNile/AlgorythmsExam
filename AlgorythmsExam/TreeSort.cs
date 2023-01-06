namespace AlgorythmsExam;

public class TreeSort
{
    public static void Sort(int[] array)
    {
        var enumerator = array.GetEnumerator();
        enumerator.MoveNext();
        var root = new TreeNode((int) enumerator.Current);
        while (enumerator.MoveNext())
            root.Insert((int) enumerator.Current);
        Array.Copy(root.Parse(new List<int>()).ToArray(), array, array.Length);
    }
}