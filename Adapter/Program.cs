using Adapter.Asa_Company_Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var resumeView= new ResumeView(new Resume());
            resumeView.Apply(new CTOFilterAdapter(new CTOFilter()));
                
        }
    }
}
