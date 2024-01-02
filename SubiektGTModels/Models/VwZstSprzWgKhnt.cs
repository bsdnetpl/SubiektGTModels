using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZstSprzWgKhnt
{
    public int DokId { get; set; }

    public int? DokKatId { get; set; }

    public int? DokPlatnikId { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? DokMagId { get; set; }

    public int DokStatus { get; set; }

    public DateTime DokDataWyst { get; set; }

    public string DokWystawil { get; set; } = null!;

    public int DokRodzajOperacjiVat { get; set; }

    public int? TypDlugi { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? ObId { get; set; }

    public int? ObTowId { get; set; }

    public int? ObTowRodzaj { get; set; }

    public string? ObJm { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObIlosc { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public int? ObZnak { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public bool ObOplCukrowaPodlega { get; set; }

    public decimal ObOplCukrowaObj { get; set; }

    public decimal ObOplCukrowaKwCukier { get; set; }

    public decimal ObOplCukrowaKwCukierEx { get; set; }

    public decimal ObOplCukrowaKwKofeina { get; set; }

    public decimal ObOplCukrowaWartSuma { get; set; }

    public int ObOplCukrowaSok { get; set; }

    public int ObOplCukrowaElektrolit { get; set; }

    public decimal ObOplCukrowaCukierZawartoscEx { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? DokDoDokId { get; set; }

    public int? ObDoId { get; set; }

    public int? DokNr { get; set; }
}
