using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratInfoPracUmowyCp
{
    public int UcpId { get; set; }

    public int UcpIdPracownika { get; set; }

    public string UcpNumer { get; set; } = null!;

    public string? Rodzaj { get; set; }

    public string? Okres { get; set; }

    public DateTime UcpDataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public string UcpTytul { get; set; } = null!;

    public decimal UcpKwota { get; set; }
}
