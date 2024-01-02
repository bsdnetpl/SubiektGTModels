using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwpDksKasa
{
    public int KsId { get; set; }

    public string KsSymbol { get; set; } = null!;

    public string KsNazwa { get; set; } = null!;

    public string? KsOpis { get; set; }

    public string? KsAnalityka { get; set; }

    public bool KsGlowna { get; set; }

    public string? KsWaluta { get; set; }

    public bool KsWielowalutowa { get; set; }

    public bool KsRkPersonalizacja { get; set; }

    public int? KsRkKategoria { get; set; }

    public int KsRkOkres { get; set; }

    public bool KsRkWieleZaOkres { get; set; }

    public int KsRkAutoDodawanie { get; set; }

    public int? KsRkKategoriaKorekty { get; set; }

    public int? KsRkFormatNumeru { get; set; }

    public bool KsZapisKptjakoOczekujace { get; set; }
}
