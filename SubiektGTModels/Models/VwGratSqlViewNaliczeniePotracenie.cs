using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewNaliczeniePotracenie
{
    public int Ident { get; set; }

    public string? Nazwisko { get; set; }

    public string? Imie { get; set; }

    public string? Imie2 { get; set; }

    public DateTime Data { get; set; }

    public string Nazwa { get; set; } = null!;

    public string? Rodzaj { get; set; }

    public string Opodatkowany { get; set; } = null!;

    public string DoPodstEmerytalneRentowe { get; set; } = null!;

    public string DoPodstChoroboweWypadkowe { get; set; } = null!;

    public decimal Wartosc { get; set; }

    public string Rozliczony { get; set; } = null!;

    public string SposobRozliczenia { get; set; } = null!;

    public string? DokumentRozliczajacy { get; set; }

    public decimal? SumaNaliczen { get; set; }

    public decimal? SumaPotracen { get; set; }

    public string NalpOpis { get; set; } = null!;
}
