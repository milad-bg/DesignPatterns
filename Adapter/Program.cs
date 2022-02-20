using Adapter.Asa_Company_Filters;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var resumeView = new ResumeView(new Resume());
            resumeView.Apply(new CTOFilterAdapter(new CTOFilter()));

        }
    }
}
