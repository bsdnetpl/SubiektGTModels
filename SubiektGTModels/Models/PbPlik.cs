using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PbPlik
{
    public int PbpId { get; set; }

    public int PbpIdDokumentu { get; set; }

    public string PbpIdBiura { get; set; } = null!;

    public string PbpNazwa { get; set; } = null!;

    public DateTime PbpData { get; set; }

    public int PbpRozmiar { get; set; }

    public int? PbpKolejnosc { get; set; }

    public string? PbpKomentarz { get; set; }

    public byte[]? PbpOcr { get; set; }

    public virtual PbDokument PbpIdDokumentuNavigation { get; set; } = null!;
}
