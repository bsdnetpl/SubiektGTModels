using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratProwizje
{
    public int Ident { get; set; }

    public int Status { get; set; }

    public DateTime Data { get; set; }

    public string? Zatrudnienie { get; set; }

    public string? Pracownik { get; set; }

    public string? Umowa { get; set; }

    public string? RodzajUmowy { get; set; }

    public int? RodzajUmowyId { get; set; }

    public string StawkaProwizyjna { get; set; } = null!;

    public int StawkaId { get; set; }

    public decimal Ilosc { get; set; }

    public decimal Wartosc { get; set; }

    public string? DokumentRozliczajacy { get; set; }

    public int? UmowaId { get; set; }

    public int? UmowaCpId { get; set; }

    public int Sposob { get; set; }

    public int? RachId { get; set; }

    public int? WyplataId { get; set; }

    public int? PrId { get; set; }

    public int? PrIdGrupy { get; set; }
}
