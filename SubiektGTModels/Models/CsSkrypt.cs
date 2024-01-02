using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CsSkrypt
{
    public int CssId { get; set; }

    public int? CssTypObiektu { get; set; }

    public int? CssTypObiektuEx { get; set; }

    public int CssZdarzenie { get; set; }

    public bool CssAktywny { get; set; }

    public int CssKolejnosc { get; set; }

    public string CssNazwa { get; set; } = null!;

    public string? CssOpis { get; set; }

    public string? CssProducent { get; set; }

    public string? CssKontakt { get; set; }

    public string? CssWersja { get; set; }

    public string CssSkrypt { get; set; } = null!;

    public string? CssAssemblies { get; set; }

    public string? CssNamespaces { get; set; }

    public string? CssHaslo { get; set; }
}
