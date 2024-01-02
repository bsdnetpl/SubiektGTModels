using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NkSzablon
{
    public int NuId { get; set; }

    public int NuIdZrodlaDanych { get; set; }

    public int? NuIdWzorca { get; set; }

    public string NuNazwa { get; set; } = null!;

    public int NuSzerStrony { get; set; }

    public int NuWysStrony { get; set; }

    public int NuMargLewy { get; set; }

    public int NuMargGorny { get; set; }

    public int NuSzerNakl { get; set; }

    public int NuWysNakl { get; set; }

    public int NuSzerOdstep { get; set; }

    public int NuWysOdstep { get; set; }

    public int NuKolumny { get; set; }

    public int NuWiersze { get; set; }

    public virtual ICollection<NkPoleSzablonu> NkPoleSzablonus { get; set; } = new List<NkPoleSzablonu>();

    public virtual NkUkladWzorcowy? NuIdWzorcaNavigation { get; set; }

    public virtual NkZrodloDanych NuIdZrodlaDanychNavigation { get; set; } = null!;
}
