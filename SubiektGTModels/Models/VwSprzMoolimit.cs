using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSprzMoolimit
{
    public int? DokId { get; set; }

    public int? DokPlatnikId { get; set; }

    public int? DokTyp { get; set; }

    public int? DokRodzajOperacjiVat { get; set; }

    public int? DokTransakcjaJednolitaId { get; set; }

    public int? ObId { get; set; }

    public int? ObTowId { get; set; }

    public decimal? ObIlosc { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObCenaMag { get; set; }

    public decimal? ObCenaWalutaPln { get; set; }

    public decimal? ObCenaNetto { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObRabat { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartVat { get; set; }

    public decimal? ObWartBrutto { get; set; }
}
