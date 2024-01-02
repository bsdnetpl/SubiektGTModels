using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzSyncHistoriaRozliczeniaPozostalo
{
    public int NzshrpRozrachId { get; set; }

    public int NzshrpIdDokumentAuto { get; set; }

    public decimal NzshrpWartoscPln { get; set; }

    public decimal NzshrpWartosc { get; set; }

    public string NzshrpWaluta { get; set; } = null!;
}
