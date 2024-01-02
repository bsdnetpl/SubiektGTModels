using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneTowar
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

    public bool? TwIsFundPromocji { get; set; }

    public int? TwIdFundPromocji { get; set; }

    public int? TwDomyslnaKategoria { get; set; }

    public decimal? TwWysokosc { get; set; }

    public decimal? TwSzerokosc { get; set; }

    public decimal? TwGlebokosc { get; set; }

    public decimal? TwStanMaks { get; set; }

    public bool TwAkcyza { get; set; }

    public bool TwAkcyzaZaznacz { get; set; }

    public decimal? TwAkcyzaKwota { get; set; }

    public bool TwObrotMarza { get; set; }

    public bool TwOdwrotneObciazenie { get; set; }

    public int TwProgKwotowyOo { get; set; }

    public bool TwDodawalnyDoZw { get; set; }

    public string? TwIsbn { get; set; }

    public string? TwBloz7 { get; set; }

    public string? TwBloz12 { get; set; }

    public string? TwKodUproducenta { get; set; }

    public string? TwKomunikat { get; set; }

    public DateTime? TwKomunikatOd { get; set; }

    public int TwKomunikatDokumenty { get; set; }

    public bool TwMechanizmPodzielonejPlatnosci { get; set; }

    public int TwGrupaJpkVat { get; set; }

    public int? PwdId { get; set; }

    public int? PwdTypObiektu { get; set; }

    public int? PwdIdObiektu { get; set; }

    public int? PwdIdPozycji { get; set; }

    public DateTime? PwdData01 { get; set; }

    public DateTime? PwdData02 { get; set; }

    public DateTime? PwdData03 { get; set; }

    public DateTime? PwdData04 { get; set; }

    public DateTime? PwdData05 { get; set; }

    public DateTime? PwdData06 { get; set; }

    public DateTime? PwdData07 { get; set; }

    public DateTime? PwdData08 { get; set; }

    public DateTime? PwdData09 { get; set; }

    public DateTime? PwdData10 { get; set; }

    public int? PwdLiczba01 { get; set; }

    public int? PwdLiczba02 { get; set; }

    public int? PwdLiczba03 { get; set; }

    public int? PwdLiczba04 { get; set; }

    public int? PwdLiczba05 { get; set; }

    public int? PwdLiczba06 { get; set; }

    public int? PwdLiczba07 { get; set; }

    public int? PwdLiczba08 { get; set; }

    public int? PwdLiczba09 { get; set; }

    public int? PwdLiczba10 { get; set; }

    public string? PwdTekst01 { get; set; }

    public string? PwdTekst02 { get; set; }

    public string? PwdTekst03 { get; set; }

    public string? PwdTekst04 { get; set; }

    public string? PwdTekst05 { get; set; }

    public string? PwdTekst06 { get; set; }

    public string? PwdTekst07 { get; set; }

    public string? PwdTekst08 { get; set; }

    public string? PwdTekst09 { get; set; }

    public string? PwdTekst10 { get; set; }

    public decimal? PwdKwota01 { get; set; }

    public decimal? PwdKwota02 { get; set; }

    public decimal? PwdKwota03 { get; set; }

    public decimal? PwdKwota04 { get; set; }

    public decimal? PwdKwota05 { get; set; }

    public decimal? PwdKwota06 { get; set; }

    public decimal? PwdKwota07 { get; set; }

    public decimal? PwdKwota08 { get; set; }

    public decimal? PwdKwota09 { get; set; }

    public decimal? PwdKwota10 { get; set; }

    public int? PwdFk01 { get; set; }

    public int? PwdFk02 { get; set; }

    public int? PwdFk03 { get; set; }

    public int? PwdFk04 { get; set; }

    public int? PwdFk05 { get; set; }

    public int? PwdFk06 { get; set; }

    public int? PwdFk07 { get; set; }

    public int? PwdFk08 { get; set; }

    public int? PwdFk09 { get; set; }

    public int? PwdFk10 { get; set; }

    public bool? PwdFlaga01 { get; set; }

    public bool? PwdFlaga02 { get; set; }

    public bool? PwdFlaga03 { get; set; }

    public bool? PwdFlaga04 { get; set; }

    public bool? PwdFlaga05 { get; set; }

    public bool? PwdFlaga06 { get; set; }

    public bool? PwdFlaga07 { get; set; }

    public bool? PwdFlaga08 { get; set; }

    public bool? PwdFlaga09 { get; set; }

    public bool? PwdFlaga10 { get; set; }
}
