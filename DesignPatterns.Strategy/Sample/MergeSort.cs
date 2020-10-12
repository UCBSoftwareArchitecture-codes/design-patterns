using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Sample
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}