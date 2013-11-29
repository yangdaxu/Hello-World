using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{

    /// <summary>
    /// 各种排序方法
    /// </summary>
    public class sort
    {
        public void Run()
        {
            int lenght = 20000000;
            //int lenght = 100;
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            int[] array = BuildRanArray(lenght);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数生成用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);

            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
            QuickSort(array);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数快速排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);

            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
            HeapSort(array);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数堆排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);

            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
             MergeSort(array,array.Length);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数归并排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);
            //foreach (int i in array)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.WriteLine();

            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
            InsertSort(array);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数插入排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);


            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
            SelectSort(array);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数选择排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);

            array = BuildRanArray(lenght);
            Stopwatch.Reset();
            Stopwatch.Start();
            BubbleSort(array);
            Stopwatch.Stop();
            Console.WriteLine("{0}个数冒泡排序用时：{1}", lenght, Stopwatch.ElapsedMilliseconds);
            //foreach (int i in array)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            //Console.WriteLine();
        }

        int[] BuildRanArray(int length)
        {
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            int[] a = new int[length];
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }

            Random random = new Random();
            int RanIndex;
            int end = length;
            for (int i = 0; i < length; i++)
            {
                RanIndex = random.Next(0, end);
                output[i] = a[RanIndex];
                a[RanIndex] = a[end - 1];
                end--;
            }
            Stopwatch.Stop();
            Console.WriteLine("{0}个数生成用时：{1}", length, Stopwatch.ElapsedMilliseconds);
            return output;
        }

        public void RunHeapSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            HeapSort(array);
            Console.WriteLine("{0}个数堆排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        void HeapSort(int[] array)
        {
            int tmp;
            BuildHeap(array);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                tmp = array[0];
                array[0] = array[i];
                array[i] = tmp;
                BuildHeap(array, 0, i - 1);
            }
        }
        void BuildHeap(int[] array)
        {
            for (int i = (array.Length - 1) / 2; i >= 0; i--)
            {
                BuildHeap(array, i, array.Length - 1);
            }
        }
        void BuildHeap(int[] array, int low, int high)
        {
            int i = low;
            int j = 2 * i + 1;
            int tmp = array[low];
            while (j <= high)
            {
                if (j + 1 <= high && array[j] < array[j + 1])
                {
                    j++;
                }
                if (array[j] > tmp)
                {
                    array[i] = array[j];
                    i = j;
                    j = 2 * j + 1;
                }
                else
                {
                    break;
                }
            }
            array[i] = tmp;
        }

        public void RunQuickSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            QuickSort(array);
            Console.WriteLine("{0}个数快速排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        void QuickSort(int[] array, int low, int high)
        {
            int i = low;
            int j = high;
            int tmp = array[low];
            while (high > low)
            {
                while (low < high && array[high] >= tmp)
                {
                    high--;
                }
                array[low] = array[high];
                while (low < high && array[low] <= tmp)
                {
                    low++;
                }
                array[high] = array[low];
            }
            array[low] = tmp;
            if (i + 1 < low)
            {
                QuickSort(array, i, low - 1);
            }
            if (j - 1 > high)
            {
                QuickSort(array, high + 1, j);
            }
        }

        public void RunBubbleSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            BubbleSort(array);
            Console.WriteLine("{0}个数冒泡排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        void BubbleSort(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        public void RunInsertSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            InsertSort(array);
            Console.WriteLine("{0}个数直接插入排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        void InsertSort(int[] array)
        {
            int tmp;
            int j;
            for (int i = 0; i < array.Length - 1; i++)
            {
                j = i + 1;
                tmp = array[j];
                while (j > 0)
                {
                    if (array[j - 1] > tmp)
                    {
                        array[j] = array[--j];
                    }
                    else
                    {
                        break;
                    }
                }
                array[j] = tmp;
            }
        }

        public void RunSelectSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            SelectSort(array);
            Console.WriteLine("{0}个数选择排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        void SelectSort(int[] array)
        {
            int tmp;
            int minIndex;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    tmp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = tmp;
                }
            }
        }

        int[] MergeSort(int[] lst)
        {
            if (lst.Length <= 1)
            {
                return lst;
            }
            int mid = lst.Length / 2;
            int[] left = new int[mid];//定义左侧List
            int[] right = new int[lst.Length - mid];//定义右侧List           

            //以下兩個循環把lst分為左右兩個List
            for (int i = 0; i < mid; i++)
            {
                left[i] = lst[i];
            }
            for (int j = mid; j < lst.Length; j++)
            {
                right[j - mid] = lst[j];
            }
            left = MergeSort(left);
            right = MergeSort(right);
            return merge(left, right);
        }

        int[] merge(int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int[] tmp = new int[leftLength + rightLength];
            int leftIndex = 0;
            int rightIndex = 0;
            int index = 0;
            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (left[leftIndex] > right[rightIndex])
                {
                    tmp[index++] = right[rightIndex++];
                }
                else
                {
                    tmp[index++] = left[leftIndex++];
                }
            }
            while (leftIndex < leftLength)
            {
                tmp[index++] = left[leftIndex++];
            }
            while (rightIndex < rightLength)
            {
                tmp[index++] = right[rightIndex++];
            }
            return tmp;
        }

        //将有二个有序数列a[first...mid]和a[mid...last]合并。
        void mergearray(int[] a, int first, int mid, int last, int[] temp)
        {
            int i = first, j = mid + 1;
            int m = mid, n = last;
            int k = 0;

            while (i <= m && j <= n)
            {
                if (a[i] <= a[j])
                    temp[k++] = a[i++];
                else
                    temp[k++] = a[j++];
            }

            while (i <= m)
                temp[k++] = a[i++];

            while (j <= n)
                temp[k++] = a[j++];

            for (i = 0; i < k; i++)
                a[first + i] = temp[i];
        }
        void mergesort(int[] a, int first, int last, int[] temp)
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                mergesort(a, first, mid, temp);    //左边有序
                mergesort(a, mid + 1, last, temp); //右边有序
                mergearray(a, first, mid, last, temp); //再将二个有序数列合并
            }
        }

        public void RunMergeSort(object len)
        {
            int length = (int)len;
            int[] array = BuildRanArray(length);
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            MergeSort(array);
            Console.WriteLine("{0}个数归并排序用时：{1}", length, Stopwatch.ElapsedMilliseconds);
        }
        bool MergeSort(int[] a, int n)
        {
            int[] p = new int[n];
            mergesort(a, 0, n - 1, p);
            return true;
        }
    }
}
