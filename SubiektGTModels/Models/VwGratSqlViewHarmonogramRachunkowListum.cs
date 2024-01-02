using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewHarmonogramRachunkowListum
{
    public int Ident { get; set; }

    public string Opis { get; set; } = null!;

    public string? RodzajHarmonogramu { get; set; }

    public int RodzajHarmonogramuId { get; set; }

    public DateTime DataRachunku { get; set; }

    public string? RodzajCyklu { get; set; }

    public DateTime? DataObowiazywaniaOd { get; set; }

    public DateTime? DataObowiazywaniaDo { get; set; }

    public string? DzienRachunku { get; set; }

    public decimal KwotaRachunku { get; set; }

    public decimal KwotaPotracen { get; set; }

    public string RozliczAkordy { get; set; } = null!;

    public string RozliczProwizje { get; set; } = null!;

    public string RozliczEcp { get; set; } = null!;

    public int UchIdUmowy { get; set; }
}
