using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozSplatyRozliczenium
{
    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public int NzfTyp { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public decimal NzfWartoscPierwotnaWaluta { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public decimal NzfSplata { get; set; }

    public decimal NzfSplataWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public string? NzfTytulem { get; set; }

    public DateTime? NzfDataOstatniejSplaty { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int? NzfIdHistoriiAdresu { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public int NzfStatus { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int NzfIdWystawil { get; set; }

    public bool NzfNota { get; set; }

    public int? NzfPodtyp { get; set; }

    public int? NzfZrodlo { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfIdRozrachunku { get; set; }

    public bool NzfPowiazanie { get; set; }

    public bool NzfKorekta { get; set; }

    public string? NzfTransakcja { get; set; }

    public string? NzfNumerPelny { get; set; }

    public int? DniSpoznienia { get; set; }

    public decimal WartoscPierwotna { get; set; }

    public decimal WartoscPierwotnaWaluta { get; set; }

    public decimal? Wartosc { get; set; }

    public decimal? WartoscWaluta { get; set; }

    public int? Rozliczenie { get; set; }

    public int? DokPlatnikAdresHid { get; set; }

    public int? DokTyp { get; set; }

    public string? NzfWystawil { get; set; }

    public int? NzfFlaga { get; set; }

    public int? NzfFlagaZmianaPersonelId { get; set; }

    public DateTime? NzfFlagaZmianaCzas { get; set; }

    public int NzfLiczbaJednostek { get; set; }

    public int? RodzajSplaty { get; set; }

    public bool NzfDlaNieznany { get; set; }

    public int? DokMagId { get; set; }

    public bool NzfMetodaKasowa { get; set; }

    public int NzfPodtypPp { get; set; }

    public decimal NzfVatpierwotnyWaluta { get; set; }

    public decimal? PotVatDoZablokowania { get; set; }

    public decimal? PotVatDoOdblokowania { get; set; }

    public decimal? ZablokowanoVat { get; set; }

    public decimal? OdblokowanoVat { get; set; }

    public bool NzfMechanizmPodzielonejPlatnosci { get; set; }

    public bool NzfPrzedplataOddzial { get; set; }

    public int? NzfIdSyncDivision { get; set; }

    public int NzsId { get; set; }

    public int? NzsIdSplaty { get; set; }

    public int NzsIdDlugu { get; set; }

    public decimal NzsWartoscWaluta { get; set; }

    public string NzsIdWaluty { get; set; } = null!;

    public DateTime NzsData { get; set; }

    public int NzsTyp { get; set; }

    public int? NzsIdKompensaty { get; set; }

    public bool NzsAuto { get; set; }

    public bool NzsPrzedplata { get; set; }

    public decimal NzsWartoscWalutaDlugu { get; set; }

    public string NzsIdWalutyDlugu { get; set; } = null!;

    public decimal? NzsWartoscSplatyPln { get; set; }

    public decimal? NzsWartoscDluguPln { get; set; }

    public bool NzsWylaczBadanieZgodnosci { get; set; }

    public bool NzsMetodaKasowa { get; set; }

    public int NzsRodzaj { get; set; }

    public bool NzsAutoPrzeliczanie { get; set; }

    public int NzsStatusKsieg { get; set; }

    public bool NzsBrakKontroliSumy { get; set; }

    public int NzsIdTransakcjiVat { get; set; }

    public int? NzsIdKategorii { get; set; }

    public decimal NzsVatdluguWaluta { get; set; }

    public decimal NzsVatsplatyWaluta { get; set; }

    public decimal? NzsWartosc { get; set; }

    public string IdWalutyRozRozliczanego { get; set; } = null!;

    public string IdWalutyDokRozliczajacego { get; set; } = null!;

    public int TypDlugu { get; set; }
}
