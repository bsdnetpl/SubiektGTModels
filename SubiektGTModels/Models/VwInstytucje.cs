using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwInstytucje
{
    public int IsId { get; set; }

    public string IsSymbol { get; set; } = null!;

    public int IsRodzaj { get; set; }

    public string IsWww { get; set; } = null!;

    public string IsEmail { get; set; } = null!;

    public string? IsNrAnalityka { get; set; }

    public int? IsRachunekPit { get; set; }

    public int? IsRachunekVat { get; set; }

    public int? IsRachunekCit { get; set; }

    public int? IsKodUs { get; set; }

    public bool IsFunduszPromocji { get; set; }

    public int? IsSposobNaliczania { get; set; }

    public decimal? IsWartoscNaliczenia { get; set; }

    public int? IsIdRachunkuWirtualnego { get; set; }

    public bool IsIzbaCelna { get; set; }

    public string IsNazwaPelna { get; set; } = null!;
}
