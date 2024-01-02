using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZstOplatySpecjalneWgAsortymentu
{
    public int? DokId { get; set; }

    public int? DokTyp { get; set; }

    public int? DokPodtyp { get; set; }

    public int? DokStatus { get; set; }

    public int? DokStatusFiskal { get; set; }

    public bool? PosiadaNip { get; set; }

    public int? DokRodzajOperacjiVat { get; set; }

    public int? DokMagId { get; set; }

    public DateTime? DokDataWyst { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public string? DokNrPelny { get; set; }

    public int? DokNr { get; set; }

    public bool? DokPodlegaOplSpec { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? AdrhAdres { get; set; }

    public string? AdrhMiejscowosc { get; set; }

    public int? TwId { get; set; }

    public int? TwRodzaj { get; set; }

    public string? TwSymbol { get; set; }

    public string? TwNazwa { get; set; }

    public decimal? TwMasa { get; set; }

    public int? TwIdGrupa { get; set; }

    public string? GrtNazwa { get; set; }

    public decimal? ObIloscMag { get; set; }

    public int SosTyp { get; set; }

    public decimal? SosStawka { get; set; }

    public decimal? SosKwotaOplaty { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal? ObWartBrutto { get; set; }
}
