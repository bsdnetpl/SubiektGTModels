using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZwrotPozycja
{
    public int ObId { get; set; }

    public int? ObDoId { get; set; }

    public short ObZnak { get; set; }

    public int? ObStatus { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartVat { get; set; }

    public decimal? ObWartBrutto { get; set; }
}
