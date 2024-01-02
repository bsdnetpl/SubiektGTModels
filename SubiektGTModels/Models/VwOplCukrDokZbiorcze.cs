using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwOplCukrDokZbiorcze
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

    public decimal? IloscZnakMag { get; set; }

    public decimal? IloscZnak { get; set; }

    public bool ObOplCukrowaPodlega { get; set; }

    public decimal ObOplCukrowaObj { get; set; }

    public decimal ObOplCukrowaKwCukier { get; set; }

    public decimal ObOplCukrowaKwCukierEx { get; set; }

    public decimal ObOplCukrowaKwKofeina { get; set; }

    public decimal ObOplCukrowaWartSuma { get; set; }

    public int ObOplCukrowaSok { get; set; }

    public int ObOplCukrowaElektrolit { get; set; }

    public decimal ObOplCukrowaCukierZawartoscEx { get; set; }
}
