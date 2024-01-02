using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratUpZpLookup
{
    public int UpzId { get; set; }

    public string UpzNazwa { get; set; } = null!;

    public int? UpzIdSzablonuLp { get; set; }

    public string? SlpNazwa { get; set; }

    public bool UpzRozliczacEcp { get; set; }

    public bool UpzRozliczacNadgodziny { get; set; }

    public bool UpzRozliczacAkordy { get; set; }

    public bool UpzRozliczacProwizje { get; set; }

    public bool UpzRozliczacNaliczeniaPotracenia { get; set; }

    public bool UpzRozliczacPotraceniaKomornicze { get; set; }

    public string UpNumer { get; set; } = null!;

    public string Pracownik { get; set; } = null!;

    public DateTime DataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public int UpRodzaj { get; set; }

    public int UpId { get; set; }

    public int PrId { get; set; }

    public bool UpzUzupelniacDoMinimalnej { get; set; }
}
