using System;

namespace Adapter
{
    class SeniorFilter : IMofidCompanyFilter
    {
        public void Apply(Resume resume) =>
            Console.WriteLine("the filter that is applying is for senior members of this company ....");

    }
}
