using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendDzien
{
    public int SldId { get; set; }

    public int SldIdCykl { get; set; }

    public int? SldIdAtrybut { get; set; }

    public int SldNr { get; set; }

    public string SldNazwa { get; set; } = null!;

    public int SldRodzaj { get; set; }

    public int? SldIleDzienne { get; set; }

    public int? SldIleNocne { get; set; }

    public int? SldTypDniaWolnego { get; set; }

    public int SldTypPracy { get; set; }

    public virtual SlTypDniaWolnego? SldTypDniaWolnegoNavigation { get; set; }
}
