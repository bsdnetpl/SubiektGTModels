using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZstRaportFunduszePromocji
{
    public int DokId { get; set; }

    public DateTime DokDataWyst { get; set; }

    public string? AdrhNazwaPelna { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public string? AdrNazwa { get; set; }

    public decimal? WartNaliczenia { get; set; }

    public int DokStatus { get; set; }

    public int? DokKatId { get; set; }

    public int? DokMagId { get; set; }

    public bool DokNaliczajFundusze { get; set; }

    public int DokRodzajOperacjiVat { get; set; }

    public int? TypDlugi { get; set; }
}
