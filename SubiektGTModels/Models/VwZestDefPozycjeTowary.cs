using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZestDefPozycjeTowary
{
    public int TwId { get; set; }

    public bool TwZablokowany { get; set; }

    public int TwRodzaj { get; set; }

    public string TwSymbol { get; set; } = null!;

    public string TwNazwa { get; set; } = null!;

    public string TwOpis { get; set; } = null!;

    public int? TwIdVatSp { get; set; }

    public int? TwIdVatZak { get; set; }

    public bool TwJakPrzySp { get; set; }

    public string TwJednMiary { get; set; } = null!;

    public string TwPkwiU { get; set; } = null!;

    public string TwSww { get; set; } = null!;

    public int? TwIdRabat { get; set; }

    public int? TwIdOpakowanie { get; set; }

    public bool TwPrzezWartosc { get; set; }

    public int? TwIdPodstDostawca { get; set; }

    public string TwDostSymbol { get; set; } = null!;

    public int? TwCzasDostawy { get; set; }

    public string TwUrzNazwa { get; set; } = null!;

    public int? TwPlu { get; set; }

    public string TwPodstKodKresk { get; set; } = null!;

    public int? TwIdTypKodu { get; set; }

    public bool TwCenaOtwarta { get; set; }

    public bool? TwWagaEtykiet { get; set; }

    public bool TwKontrolaTw { get; set; }

    public decimal? TwStanMin { get; set; }

    public string? TwJednStanMin { get; set; }

    public int? TwDniWaznosc { get; set; }

    public int? TwIdGrupa { get; set; }

    public string TwWww { get; set; } = null!;

    public bool TwSklepInternet { get; set; }

    public string TwPole1 { get; set; } = null!;

    public string TwPole2 { get; set; } = null!;

    public string TwPole3 { get; set; } = null!;

    public string TwPole4 { get; set; } = null!;

    public string TwPole5 { get; set; } = null!;

    public string TwPole6 { get; set; } = null!;

    public string TwPole7 { get; set; } = null!;

    public string TwPole8 { get; set; } = null!;

    public string TwUwagi { get; set; } = null!;

    public byte[]? TwLogo { get; set; }

    public bool TwUsuniety { get; set; }

    public decimal? TwObjetosc { get; set; }

    public decimal? TwMasa { get; set; }

    public string? TwCharakter { get; set; }

    public string TwJednMiaryZak { get; set; } = null!;

    public bool TwJmzakInna { get; set; }

    public string? TwKodTowaru { get; set; }

    public int? TwIdKrajuPochodzenia { get; set; }

    public int? TwIdUjm { get; set; }

    public string TwJednMiarySprz { get; set; } = null!;

    public bool TwJmsprzInna { get; set; }

    public bool TwSerwisAukcyjny { get; set; }

    public int? TwIdProducenta { get; set; }

    public bool TwSprzedazMobilna { get; set; }

    public int ObId { get; set; }

    public int? ObDoId { get; set; }

    public short ObZnak { get; set; }

    public int? ObStatus { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public string? ObOpis { get; set; }

    public int? ObDokHanLp { get; set; }

    public int? ObDokMagLp { get; set; }

    public decimal? ObIlosc { get; set; }

    public decimal? ObIloscMag { get; set; }

    public string? ObJm { get; set; }

    public decimal ObCenaMag { get; set; }

    public decimal ObCenaWaluta { get; set; }

    public decimal ObCenaNetto { get; set; }

    public decimal ObCenaBrutto { get; set; }

    public decimal ObRabat { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartVat { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public int? ObVatId { get; set; }

    public decimal ObVatProc { get; set; }

    public DateTime? ObTermin { get; set; }

    public int? ObMagId { get; set; }

    public string? ObNumerSeryjny { get; set; }
}
