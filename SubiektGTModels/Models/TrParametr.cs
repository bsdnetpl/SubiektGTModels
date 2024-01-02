using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TrParametr
{
    public int TrpId { get; set; }

    public int? TrpDokZamowienie { get; set; }

    public int? TrpDokKoncowy { get; set; }

    public int? TrpScenariusz { get; set; }

    public int? TrpGrupa { get; set; }

    public int? TrpParamEwidId { get; set; }

    public string? TrpTerminRealizacji { get; set; }

    public string? TrpWarunkiPlatnosci { get; set; }

    public string? TrpWarunkiDostawy { get; set; }

    public string? TrpUwagiDok { get; set; }

    public bool? TrpPokazujWkal { get; set; }

    public string? TrpKolor { get; set; }

    public int? TrpCzasTrwania { get; set; }

    public bool TrpOkreslGodzine { get; set; }

    public virtual ParEwid? TrpParamEwid { get; set; }
}
