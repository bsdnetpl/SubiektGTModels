using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokumenty2
{
    public int DokId { get; set; }

    public int DokStatus { get; set; }

    public int? DokStatusEx { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public DateTime DokDataWyst { get; set; }

    public DateTime DokDataZakonczenia { get; set; }

    public int? DokDoDokId { get; set; }

    public int? DokMagId { get; set; }

    public int? ObTowId { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public int? ObKategoriaId { get; set; }
}
