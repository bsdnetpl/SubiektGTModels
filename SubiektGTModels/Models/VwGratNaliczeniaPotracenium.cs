using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratNaliczeniaPotracenium
{
    public int Ident { get; set; }

    public int Status { get; set; }

    public int Typ { get; set; }

    public DateTime Data { get; set; }

    public string? Zatrudnienie { get; set; }

    public string? Pracownik { get; set; }

    public string? Umowa { get; set; }

    public string Skladnik { get; set; } = null!;

    public int SkladnikId { get; set; }

    public decimal? Naliczenie { get; set; }

    public decimal? Potracenie { get; set; }

    public decimal? Parametr { get; set; }

    public string? DokumentRozliczajacy { get; set; }

    public int Sposob { get; set; }

    public int UmowaId { get; set; }

    public int? WyplataId { get; set; }

    public int? PrId { get; set; }

    public int? PrIdGrupy { get; set; }
}
