using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiSprzedazPozycja
{
    public int MipId { get; set; }

    public int MipIdSprzedazy { get; set; }

    public string MipIdProduktu { get; set; } = null!;

    public string MipOpisProduktu { get; set; } = null!;

    public decimal MipCenaNetto { get; set; }

    public decimal MipCenaNettoPartnera { get; set; }

    public bool? MipCzyCenaPromocyjna { get; set; }

    public int? MipIloscJednostek { get; set; }

    public int? MipTypJednostek { get; set; }

    public string? MipKodLicencji { get; set; }

    public virtual MiSprzedaz MipIdSprzedazyNavigation { get; set; } = null!;
}
