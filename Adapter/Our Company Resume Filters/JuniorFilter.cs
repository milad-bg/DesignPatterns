using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class JuniorFilter : IMofidCompanyFilter
    {
        public void Apply(Resume resume) =>
            Console.WriteLine("the filter that is applying is for junior members of this company ....");

    }
}
