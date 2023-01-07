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
 *      10)ABCSort      +
 *      11)Stack        +
 *      12)Queue        +
 *      13)HashChain    +
 *      14)HashOpen     +
 */

int [] array = {2,6,1,4,3,5,9,7,8,10,-2,-4} ;
int[] sortedArray = {0,1,2,3,5,8,13,21,34,55,89,144,233};
//int[] arr = { 3,1,5,6,2,4};
string[] wordArray = {"b","a","d","c","e","f" };

Console.WriteLine("\nВходной массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}

//BubbleSort.Sort(array);
//InsertionSort.Sort(arr);
//SelectionSort.Sort(array);
//ShakerSort.Sort(array);
//ShellSort.Sort(array);
//Print(BinarySearch.Search(sortedArray, 21, sortedArray[0], sortedArray.Length));
//QuickSort.QSort(array, 0, array.Length-1);
//RadixSort.Sort(array);
//TreeSort.Sort(array);

Console.WriteLine("\nОтсортированный массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}
