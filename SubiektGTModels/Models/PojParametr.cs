using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PojParametr
{
    public int PpId { get; set; }

    public int? PpPrzejazdIdTrasy { get; set; }

    public int? PpPrzejazdIdCelu { get; set; }

    public int? PpRachunekIdKategorii { get; set; }

    public int? PpRachunekIdEwidVat { get; set; }

    public int? PpRachunekIdKategoriiVat { get; set; }

    public int? PpRachunekRodzajVat { get; set; }

    public int? PpRachunekOdliczenieVat { get; set; }

    public int? PpParamEwidId { get; set; }

    public int PpPrzejazdWylicz { get; set; }

    public int? PpRachunekStawkaVat { get; set; }

    public virtual ParEwid? PpParamEwid { get; set; }

    public virtual SlPojCel? PpPrzejazdIdCeluNavigation { get; set; }

    public virtual SlPojTrasa? PpPrzejazdIdTrasyNavigation { get; set; }

    public virtual SlTypEwidVat? PpRachunekIdEwidVatNavigation { get; set; }

    public virtual SlKategorium? PpRachunekIdKategoriiNavigation { get; set; }

    public virtual SlKategorium? PpRachunekIdKategoriiVatNavigation { get; set; }
}
