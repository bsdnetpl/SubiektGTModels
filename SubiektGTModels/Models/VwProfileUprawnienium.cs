using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileUprawnienium
{
    public int UprId { get; set; }

    public string? UprModul { get; set; }

    public string? UprNazwa { get; set; }

    public bool NvpProfilowanieKlientowStylGt { get; set; }

    public bool? UprMagazynowe { get; set; }

    public int UprStatusNowosci { get; set; }
}
