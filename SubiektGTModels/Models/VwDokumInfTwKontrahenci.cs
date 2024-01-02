using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokumInfTwKontrahenci
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? DokPlatnikId { get; set; }

    public int? DokOdbiorcaId { get; set; }

    public int? DokDoDokId { get; set; }

    public int DokStatus { get; set; }

    public int? DokMagId { get; set; }

    public int? ObTowId { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public decimal? ObWartNetto { get; set; }

    public DateTime DokDataWyst { get; set; }
}
