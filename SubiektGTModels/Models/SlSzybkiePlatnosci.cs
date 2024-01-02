using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSzybkiePlatnosci
{
    public int SlspId { get; set; }

    public string SlspNazwa { get; set; } = null!;

    public int SlspDostawca { get; set; }

    public string SlspIdSprzedawcy { get; set; } = null!;

    public string SlspCrc { get; set; } = null!;

    public int SlspKontrahentCesyjnyId { get; set; }

    public bool SlspAktywnosc { get; set; }

    public bool SlspTest { get; set; }

    public int SlspTerminPlatnosci { get; set; }

    public string? SlspProviderId { get; set; }

    public int? SlspIdParser { get; set; }

    public virtual ICollection<LspLinkDoSzybkiejPlatnosci> LspLinkDoSzybkiejPlatnoscis { get; set; } = new List<LspLinkDoSzybkiejPlatnosci>();

    public virtual KhKontrahent SlspKontrahentCesyjny { get; set; } = null!;
}
