using System;

namespace DesignPatterns.Strategy.Sample 
{
    public class MainApp 
    {

        static void RunMain () 
        {

            SortedList studentRecords = new SortedList ();

            studentRecords.Add ("Samual");
            studentRecords.Add ("Jimmy");
            studentRecords.Add ("Sandra");
            studentRecords.Add ("Vivek");
            studentRecords.Add ("Anna");

            studentRecords.SetSortStrategy (new QuickSort ());
            studentRecords.Sort ();

            studentRecords.SetSortStrategy (new ShellSort ());
            studentRecords.Sort ();

            studentRecords.SetSortStrategy (new MergeSort ());
            studentRecords.Sort ();

            Console.ReadKey ();
        }

    }
}