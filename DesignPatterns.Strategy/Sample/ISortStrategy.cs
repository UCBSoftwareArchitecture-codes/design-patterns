using System.Collections.Generic;

namespace DesignPatterns.Strategy.Sample
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
         
    }
}