using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseDokumentKasowy
{
    public int DksId { get; set; }

    public int? DksIdKasy { get; set; }

    public int DksTyp { get; set; }

    public int DksStatus { get; set; }

    public DateTime DksData { get; set; }

    public int? DksNumer { get; set; }

    public string? DksNumerPelny { get; set; }

    public decimal DksWartosc { get; set; }

    public decimal DksWartoscWaluta { get; set; }

    public decimal DksSplata { get; set; }

    public decimal DksSplataWaluta { get; set; }

    public string DksIdWaluty { get; set; } = null!;

    public decimal DksKurs { get; set; }

    public int DksRodzajKursu { get; set; }

    public string? DksTytulem { get; set; }

    public int? DksIdKategorii { get; set; }

    public int? DksImport { get; set; }

    public string? DksWystawil { get; set; }

    public int DksIdWystawil { get; set; }

    public string? DksOdebral { get; set; }

    public string? DksOpis { get; set; }

    public int? DksIdDokumentAuto { get; set; }

    public int? DksIdHistoriiAdresu { get; set; }

    public int? DksIdAdresu { get; set; }

    public bool DksZaliczka { get; set; }

    public int DksTypObiektu { get; set; }

    public int? DksIdObiektu { get; set; }

    public bool DksGenerujTytulem { get; set; }

    public bool DksDlaNieznany { get; set; }

    public DateTime? DksDataKursu { get; set; }

    public int? DksIdBanku { get; set; }

    public int DksLiczbaJednostek { get; set; }
}
