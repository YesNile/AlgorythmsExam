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

using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using AlgorythmsExam;

int [] array = {2,6,1,4,3,5,9,7,8,10,-2,-4} ;
int[] sortedArray = {0,1,2,3,5,8,13,21,34,55,89,144,233};
int[] radixArray = {123,543,126,856,978,234,653,978,130,534 };
//int[] arr = { 3,1,5,6,2,4};
string[] wordArray = {"b","a","d","c","e","f" };
string[] secondWordArray = {"aabout","black","ruspberry","about","day","clear","dad","house" };


Console.WriteLine("\nВходной массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}


// var test = RadixSort2.Sort(array);
// Console.WriteLine("\nОтсортированный массив:");
// foreach (var i in test)
// {
//     Console.Write($"{i} ");
// }
//ABCSort.ABSSort(secondWordArray);
//BubbleSort.Sort(array);
//InsertionSort.Sort(arr);
//SelectionSort.Sort(array);
//ShakerSort.Sort(array);
//ShellSort.Sort(array);
//Print(BinarySearch.Search(sortedArray, 21, sortedArray[0], sortedArray.Length));
QuickSort.QSort(array, 0, array.Length-1);
//RadixSort.Sort(radixArray);
//TreeSort.Sort(array);

Console.WriteLine("\nОтсортированный массив:");
foreach (var i in array)
{
    Console.Write($"{i} ");
}


void Print(int result)
{
    Console.WriteLine($"\n{result}");
}





