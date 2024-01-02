using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratPracownicyLookup
{
    public int PrId { get; set; }

    public int? PrIdGrupy { get; set; }

    public string? AdrNazwa { get; set; }

    public string PrImie { get; set; } = null!;

    public string PrNazwisko { get; set; } = null!;

    public string PrImie2 { get; set; } = null!;

    public DateTime PrDataUrodzenia { get; set; }

    public string PrNip { get; set; } = null!;

    public string PrPesel { get; set; } = null!;

    public string? AdrAdres { get; set; }

    public string? AdrMiejscowosc { get; set; }

    public string? GrpNazwa { get; set; }

    public string? UpNumer { get; set; }

    public bool PrAktywny { get; set; }
}
