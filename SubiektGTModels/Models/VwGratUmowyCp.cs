using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratUmowyCp
{
    public int Ident { get; set; }

    public string Pracownik { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public string Numer { get; set; } = null!;

    public int RodzajId { get; set; }

    public string? RodzajUmowyCp { get; set; }

    public int NaCzasId { get; set; }

    public string? NaCzas { get; set; }

    public DateTime DataRozp { get; set; }

    public DateTime? DataZak { get; set; }

    public DateTime? DataRozw { get; set; }

    public string ZatrudnienieKrotkie { get; set; } = null!;

    public string? Zatrudnienie { get; set; }

    public DateTime? DataRach { get; set; }

    public int PrId { get; set; }

    public int? PrIdGrupy { get; set; }

    public int? IdDzialu { get; set; }

    public string Nip { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public decimal Podatek { get; set; }

    public string Tytul { get; set; } = null!;

    public DateTime? DataZawarcia { get; set; }
}
