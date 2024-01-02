using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StOperacja
{
    public int StoId { get; set; }

    public int StoIdSrodka { get; set; }

    public DateTime StoData { get; set; }

    public string StoNrDok { get; set; } = null!;

    public int StoTypOper { get; set; }

    public decimal StoWartosc { get; set; }

    public decimal? StoWartoscBil { get; set; }

    public int? StoIdMpk { get; set; }

    public string? StoUzytkownik { get; set; }

    public bool? StoCzyAmort { get; set; }

    public bool? StoCzyAmortBil { get; set; }

    public int? StoMetoda { get; set; }

    public int? StoMetodaBil { get; set; }

    public decimal? StoStopa { get; set; }

    public decimal? StoStopaBil { get; set; }

    public decimal? StoWspolczynnikDegr { get; set; }

    public decimal? StoWspolczynnikDegrBil { get; set; }

    public int? StoRozpoczecieAm { get; set; }

    public int? StoRozpoczecieAmbil { get; set; }

    public bool? StoCzyPduw { get; set; }

    public decimal? StoUmorzPocz { get; set; }

    public decimal? StoUmorzPoczBil { get; set; }

    public string? StoPrzyczyna { get; set; }

    public string? StoSposob { get; set; }

    public string? StoKomisja { get; set; }

    public string? StoDokSprzedazy { get; set; }

    public string? StoNabywca { get; set; }

    public bool? StoCzyPodwyzszonaStopa { get; set; }

    public bool? StoCzyPodwyzszonaStopaBil { get; set; }

    public decimal? StoPodwyzszonaStopa { get; set; }

    public decimal? StoPodwyzszonaStopaBil { get; set; }

    public decimal? StoSumaAm { get; set; }

    public decimal? StoSumaAmbil { get; set; }

    public int StoImport { get; set; }

    public int? StoIdKategorii { get; set; }

    public int? StoLimitAmJedn { get; set; }

    public int? StoLimitAmJednBil { get; set; }

    public bool? StoKorygujPodstSklZdrOodpisyAmortyzacyjne { get; set; }

    public decimal? StoWartoscOdpisowAmortyzacyjnychSprzed2022 { get; set; }

    public decimal? StoWartoscSprzedazy { get; set; }

    public bool StoCzyPomniejszacPodstSklZdrOodpisyAmortDoWartosciSprzedazy { get; set; }

    public virtual StMpk? StoIdMpkNavigation { get; set; }

    public virtual StSrodekTrwaly StoIdSrodkaNavigation { get; set; } = null!;
}
