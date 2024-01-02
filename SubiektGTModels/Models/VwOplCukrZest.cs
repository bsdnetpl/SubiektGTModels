using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwOplCukrZest
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int DokStatus { get; set; }

    public int? DokMagId { get; set; }

    public int? TwId { get; set; }

    public int? TwIdGrupa { get; set; }

    public bool? ZawieraCukierPonad5gr { get; set; }

    public string? TwSymbol { get; set; }

    public DateTime DokDataWyst { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? DokNr { get; set; }

    public string? AdrhNip { get; set; }

    public string? AdrhSymbol { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? TwNazwa { get; set; }

    public decimal? ObjetoscWlitrach { get; set; }

    public decimal? IloscZnak { get; set; }

    public decimal? OplataDla5grCukru { get; set; }

    public decimal? OplataPowyzej5grCukru { get; set; }

    public decimal? OplataCukrowa { get; set; }

    public decimal? NadwyzkaCukruPonad5gr { get; set; }

    public bool? ObOplCukrowaSok { get; set; }

    public bool? ObOplCukrowaElektrolit { get; set; }

    public decimal? OplataKofeina { get; set; }

    public decimal? ObOplCukrowaWartSuma { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }
}
