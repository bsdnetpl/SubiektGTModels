using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokPozycjaFinalna
{
    public int? ObId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public decimal ObRabat { get; set; }

    public decimal? ObIloscMag { get; set; }

    public string? ObJm { get; set; }

    public decimal ObVatProc { get; set; }

    public decimal? CenaPierwotna { get; set; }

    public decimal? ObCenaNetto { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObCenaMag { get; set; }

    public decimal? ObCenaWaluta { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public decimal? ObWartMag { get; set; }

    public short ObZnak { get; set; }
}
