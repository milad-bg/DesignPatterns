using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SeniorFilter : IMofidCompanyFilter
    {
        public void Apply(Resume resume) =>
            Console.WriteLine("the filter that is applying is for senior members of this company ....");

    }
}   
