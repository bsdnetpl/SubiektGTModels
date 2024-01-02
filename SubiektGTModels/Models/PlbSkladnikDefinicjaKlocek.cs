using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSkladnikDefinicjaKlocek
{
    public int SpdkId { get; set; }

    public int SpdkIdDefinicji { get; set; }

    public int SpdkTyp { get; set; }

    public string SpdkDefinicja { get; set; } = null!;

    public decimal? SpdkWartoscCy { get; set; }

    public int? SpdkWartoscInt { get; set; }

    public string SpdkParamStr { get; set; } = null!;
}
