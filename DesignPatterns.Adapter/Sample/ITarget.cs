using System.Collections.Generic;

namespace DesignPatterns.Adapter.Sample
{
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}