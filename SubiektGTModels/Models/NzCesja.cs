using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzCesja
{
    public int NzcId { get; set; }

    public int NzcRodzaj { get; set; }

    public int NzcTyp { get; set; }

    public string NzcNumer { get; set; } = null!;

    public int NzcIdSplata { get; set; }

    public int NzcIdCesyjny { get; set; }

    public int NzcStatusKsieg { get; set; }

    public virtual ICollection<LspLinkDoSzybkiejPlatnosci> LspLinkDoSzybkiejPlatnoscis { get; set; } = new List<LspLinkDoSzybkiejPlatnosci>();

    public virtual NzFinanse NzcIdCesyjnyNavigation { get; set; } = null!;

    public virtual NzFinanse NzcIdSplataNavigation { get; set; } = null!;
}
