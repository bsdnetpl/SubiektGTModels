using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileModuly
{
    public int UimId { get; set; }

    public string UimTytul { get; set; } = null!;

    public string UimProgid { get; set; } = null!;

    public int UimTypKontekstu { get; set; }

    public string UimKontekst { get; set; } = null!;

    public int UimStatusNowosci { get; set; }

    public string UimOpis { get; set; } = null!;
}
