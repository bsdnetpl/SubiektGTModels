using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKwotyStawkiOplatSpecjalnychWszystkieDok
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public DateTime DokDataZakonczenia { get; set; }

    public int? ObTowId { get; set; }

    public decimal? ObIloscMag { get; set; }

    public int? ObKategoriaId { get; set; }

    public int SosTyp { get; set; }

    public decimal? SosStawka { get; set; }

    public decimal? SosKwotaOplaty { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObWartBrutto { get; set; }
}
