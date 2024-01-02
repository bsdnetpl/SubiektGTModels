using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrprowizja
{
    public int Ident { get; set; }

    public int Status { get; set; }

    public DateTime Data { get; set; }

    public string? Pracownik { get; set; }

    public string? Umowa { get; set; }

    public string? RodzajUmowy { get; set; }

    public int StawkaId { get; set; }

    public decimal Ilosc { get; set; }

    public decimal Wartosc { get; set; }

    public string? DokumentRozliczajacy { get; set; }

    public int Sposob { get; set; }

    public string Opis { get; set; } = null!;

    public int? PrId { get; set; }
}
