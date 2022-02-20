namespace Adapter
{
    class ResumeView
    {
        public Resume Resume { get; set; }
        public ResumeView(Resume resume)
        {
            this.Resume = resume;
        }

        public void Apply(IMofidCompanyFilter filter)
        {
            filter.Apply(Resume);
        }

    }
}
