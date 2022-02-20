using System;

namespace Adapter.Asa_Company_Filters
{
    class CTOFilter //we wanna use this resume filter for our company but the problem is that it doesnt impliment IMofidFilter interface so we create an adapter for it 
    {
        public void Init() { }

        public void Render(Resume resume) =>
            Console.WriteLine("Aplying the filter of a CTO member in asa co ");

    }
}
