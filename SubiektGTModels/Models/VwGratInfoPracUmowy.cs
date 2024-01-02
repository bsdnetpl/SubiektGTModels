using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratInfoPracUmowy
{
    public int UpId { get; set; }

    public int UpIdPracownika { get; set; }

    public string UpNumer { get; set; } = null!;

    public string Rodzaj { get; set; } = null!;

    public DateTime UpDataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public string? Wymiar { get; set; }

    public string? SlkNazwa { get; set; }

    public string? StnNazwa { get; set; }

    public string? DziNazwa { get; set; }
}
