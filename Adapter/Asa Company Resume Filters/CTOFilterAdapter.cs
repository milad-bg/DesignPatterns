﻿namespace Adapter.Asa_Company_Filters
{
    class CTOFilterAdapter : IMofidCompanyFilter
    {
        public CTOFilter CtoFilter { get; set; }
        public CTOFilterAdapter(CTOFilter ctoFilter)
        {
            this.CtoFilter = ctoFilter;
        }

        public void Apply(Resume resume)
        {
            CtoFilter.Init();
            CtoFilter.Render(resume);
        }
    }
}
