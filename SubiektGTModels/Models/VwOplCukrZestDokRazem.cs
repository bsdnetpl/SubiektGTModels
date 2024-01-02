using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwOplCukrZestDokRazem
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? DokNr { get; set; }

    public DateTime DokDataWyst { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int DokStatus { get; set; }

    public int? DokMagId { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public int? ObTowId { get; set; }

    public decimal? IloscZnak { get; set; }

    public bool? ObOplCukrowaSok { get; set; }

    public bool? ObOplCukrowaElektrolit { get; set; }

    public decimal? ObjetoscWlitrach { get; set; }

    public decimal? ObOplCukrowaCukierZawartoscEx { get; set; }

    public decimal? ObOplCukrowaKwCukier { get; set; }

    public decimal? ObOplCukrowaKwCukierEx { get; set; }

    public decimal? ObOplCukrowaKwKofeina { get; set; }

    public decimal? ObOplCukrowaWartSuma { get; set; }

    public decimal? ZawartoscCukruPowyzej { get; set; }
}
