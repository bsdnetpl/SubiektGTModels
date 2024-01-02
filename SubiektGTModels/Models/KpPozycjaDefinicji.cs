using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KpPozycjaDefinicji
{
    public int KppId { get; set; }

    public int KppIdDefinicji { get; set; }

    public string KppOpis { get; set; } = null!;

    public DateTime KppData { get; set; }

    public decimal KppKwotaWyliczona { get; set; }

    public decimal KppKwotaPotracona { get; set; }

    public bool KppSposobRozliczenia { get; set; }

    public string KppDokumentRozliczajacy { get; set; } = null!;

    public int? KppIdDokumentRozliczajacy { get; set; }

    public decimal KppKwotaPotraconaZzasilkow { get; set; }

    public virtual KpKomornikPozyczkaDefinicja KppIdDefinicjiNavigation { get; set; } = null!;

    public virtual PlbWyplatum? KppIdDokumentRozliczajacyNavigation { get; set; }
}
