/*
 *      1)BubbleSort    +
 *      2)InsertionSort +
 *      3)SelectionSort +
 *      4)ShakerSort    +
 *      5)ShellSort     +
 *      6)BinarySearch  +
 *      7)QuickSort     +
 *      8)BinarySort    +
 *      9)RadixSort     +
 *      10)ABCSort
 *      11)Stack
 *      12)Queue
 */

int [] array = {2,6,1,4,3,5,9,7,8,10,-2,-4} ;
int[] sortedArray = {0,1,2,3,5,8,13,21,34,55,89,144,233};

Console.WriteLine("\nВходной массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}


//BubbleSort(array);
//InsertionSort(array);
//SelectionSort(array);
//ShakerSort(array);
//ShellSort(array);
//Print(BinarySearch(sortedArray, 21, sortedArray[0], sortedArray.Length));
//QuickSort(array, 0, array.Length-1);
//RadixSort(array);
TreeSort(array);

Console.WriteLine("\nОтсортированный массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}



static void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j+1])
            {
                //(array[j + 1],array[j]) = (array[j],array[j + 1]);
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}


static void InsertionSort(int[] array)
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


static void SelectionSort(int[] array)
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


static void ShakerSort(int[] array)
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

static void ShellSort(int[] array)
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


static int BinarySearch(int[] array, int value, int min, int max)
{
    int mid = min+ (max-min) / 2;
    if (min>max)
    {
        return -1;
    }

    if (array[mid] < value)
    {
        return BinarySearch(array, value, mid + 1, max);
    }
    else if (array[mid] > value)
    {
        return BinarySearch(array, value, min, mid - 1);
    }

    return mid;
}

void Print(int result)
{
    Console.WriteLine($"\n{result}");
}

static int[] QuickSort(int[] array,int first,int last)
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
    QuickSort (array, first, pivot-1);
    QuickSort (array, pivot+1, last);
    return array;
}

static void RadixSort(int[] array)
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

static void TreeSort(int[] array)
{
    var enumerator = array.GetEnumerator();
    enumerator.MoveNext();
    var root = new TreeNode((int) enumerator.Current);
    while (enumerator.MoveNext())
        root.Insert((int) enumerator.Current);
    Array.Copy(root.Parse(new List<int>()).ToArray(), array, array.Length);
}

class TreeNode
{
    public TreeNode(int num) => number = num;
    int number;
    TreeNode? left;
    TreeNode? right;

    internal void Insert(int num)
    {
        if (num < number)
        {
            if (left == null)
                left = new TreeNode(num);
            else
                left.Insert(num);
        }
        else
        {
            if (right == null)
                right = new TreeNode(num);
            else
                right.Insert(num);
        }
    }

    internal List<int> Parse(List<int> array)
    {
        if (left != null)
            left.Parse(array);
        array.Add(number);
        if (right != null)
            right.Parse(array);
        return array;
    }
}