using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozRozliczoneRew
{
    public int? DniSpoznienia { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int NzfTyp { get; set; }

    public int NzfId { get; set; }

    public DateTime NzfData { get; set; }

    public string? NzfNumerPelny { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int NzfIdWystawil { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int NzfTypObiektu { get; set; }

    public int? NzfIdObiektu { get; set; }

    public decimal? Naleznosc { get; set; }

    public decimal? Zobowiazanie { get; set; }

    public decimal? NalWaluta { get; set; }

    public decimal? ZobWaluta { get; set; }

    public DateTime? NzfDataOstatniejSplaty { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public int? NzfPodtyp { get; set; }

    public int? DokTyp { get; set; }

    public int? DokPlatnikAdresHid { get; set; }

    public decimal NzfWartoscPierwotna { get; set; }

    public decimal NzfWartoscPierwotnaWaluta { get; set; }

    public bool NzfKorekta { get; set; }

    public string? NzfWystawil { get; set; }

    public int? NzfFlaga { get; set; }

    public int? NzfFlagaZmianaPersonelId { get; set; }

    public DateTime? NzfFlagaZmianaCzas { get; set; }

    public decimal NzfKurs { get; set; }

    public int? DokMagId { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }

    public bool NzfMechanizmPodzielonejPlatnosci { get; set; }
}
