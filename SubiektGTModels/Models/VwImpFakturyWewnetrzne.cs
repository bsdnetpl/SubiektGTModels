using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwImpFakturyWewnetrzne
{
    public int FwnId { get; set; }

    public int FwnMagId { get; set; }

    public DateTime FwnDataWyst { get; set; }

    public int? TypDlugi { get; set; }

    public string? NazwaTypu { get; set; }

    public int FwnNr { get; set; }

    public string FwnNrPelny { get; set; } = null!;

    public string FwnNrPelnyOryg { get; set; } = null!;

    public string? KhSymbol { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? AdrhAdres { get; set; }

    public string? AdrhMiejscowosc { get; set; }

    public decimal FwnWartNetto { get; set; }

    public string? KatNazwa { get; set; }

    public int FwnStatusKsieg { get; set; }

    public int? NzfIdKasy { get; set; }

    public int? NzfIdRachunku { get; set; }

    public int FwnStatus { get; set; }

    public int? KatId { get; set; }

    public int FwnTyp { get; set; }

    public int FwnPodtyp { get; set; }

    public int? FwnKhntId { get; set; }
}
