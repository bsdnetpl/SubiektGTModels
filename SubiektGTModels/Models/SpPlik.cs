using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SpPlik
{
    public int SppId { get; set; }

    public string SppNazwa { get; set; } = null!;

    public int SppIdOperacjiBankowej { get; set; }

    public int SppIdSubkonta { get; set; }

    public decimal SppSumaTransakcji { get; set; }

    public virtual ICollection<SpTransakcja> SpTransakcjas { get; set; } = new List<SpTransakcja>();

    public virtual NzFinanse SppIdOperacjiBankowejNavigation { get; set; } = null!;
}
