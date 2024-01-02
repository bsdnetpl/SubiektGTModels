using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokumenty
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public string DokNrpelny { get; set; } = null!;

    public int? DokPlatnikId { get; set; }

    public DateTime DokDataWyst { get; set; }

    public int? DokDoDokId { get; set; }

    public int? ObTowid { get; set; }

    public int? DokMagId { get; set; }

    public decimal? ObIloscMag { get; set; }

    public string? ObJm { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObCenaNetto { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public decimal? ObWartNetto { get; set; }

    public short ObZnak { get; set; }

    public int DokStatus { get; set; }

    public int? DokOdbiorcaId { get; set; }
}
