using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Sample
{
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}