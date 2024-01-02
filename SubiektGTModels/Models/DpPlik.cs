using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DpPlik
{
    public int DppId { get; set; }

    public int DppIdDokumentu { get; set; }

    public string DppIdBiura { get; set; } = null!;

    public string DppNazwa { get; set; } = null!;

    public int? DppKolejnosc { get; set; }

    public byte[]? DppOcr { get; set; }

    public int DppRozmiar { get; set; }

    public virtual DpDokument DppIdDokumentuNavigation { get; set; } = null!;
}
