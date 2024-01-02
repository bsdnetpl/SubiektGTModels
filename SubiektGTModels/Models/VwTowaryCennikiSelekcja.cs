using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwTowaryCennikiSelekcja
{
    public int TwId { get; set; }

    public bool TwZablokowany { get; set; }

    public int TwRodzaj { get; set; }

    public string TwSymbol { get; set; } = null!;

    public string TwNazwa { get; set; } = null!;

    public bool TwObrotMarza { get; set; }

    public decimal? TwAkcyzaKwota { get; set; }

    public bool TwAkcyzaZaznacz { get; set; }

    public bool TwAkcyza { get; set; }

    public decimal? TwStanMaks { get; set; }

    public decimal? TwGlebokosc { get; set; }

    public decimal? TwSzerokosc { get; set; }

    public decimal? TwWysokosc { get; set; }

    public int? TwDomyslnaKategoria { get; set; }

    public int? TwIdFundPromocji { get; set; }

    public bool? TwIsFundPromocji { get; set; }

    public bool TwSprzedazMobilna { get; set; }

    public int? TwIdProducenta { get; set; }

    public bool TwSerwisAukcyjny { get; set; }

    public bool TwJmsprzInna { get; set; }

    public string TwJednMiarySprz { get; set; } = null!;

    public int? TwIdUjm { get; set; }

    public int? TwIdKrajuPochodzenia { get; set; }

    public string? TwKodTowaru { get; set; }

    public bool TwJmzakInna { get; set; }

    public string TwJednMiaryZak { get; set; } = null!;

    public string? TwCharakter { get; set; }

    public decimal? TwMasa { get; set; }

    public decimal? TwObjetosc { get; set; }

    public bool TwUsuniety { get; set; }

    public byte[]? TwLogo { get; set; }

    public string TwUwagi { get; set; } = null!;

    public string TwPole8 { get; set; } = null!;

    public string TwPole7 { get; set; } = null!;

    public string TwPole6 { get; set; } = null!;

    public string TwPole5 { get; set; } = null!;

    public string TwPole4 { get; set; } = null!;

    public string TwPole3 { get; set; } = null!;

    public string TwPole2 { get; set; } = null!;

    public string TwPole1 { get; set; } = null!;

    public bool TwSklepInternet { get; set; }

    public string TwWww { get; set; } = null!;

    public int? TwIdGrupa { get; set; }

    public int? TwDniWaznosc { get; set; }

    public string? TwJednStanMin { get; set; }

    public decimal? TwStanMin { get; set; }

    public bool TwKontrolaTw { get; set; }

    public bool? TwWagaEtykiet { get; set; }

    public bool TwCenaOtwarta { get; set; }

    public int? TwIdTypKodu { get; set; }

    public string TwPodstKodKresk { get; set; } = null!;

    public int? TwPlu { get; set; }

    public string TwUrzNazwa { get; set; } = null!;

    public int? TwCzasDostawy { get; set; }

    public string TwDostSymbol { get; set; } = null!;

    public int? TwIdPodstDostawca { get; set; }

    public bool TwPrzezWartosc { get; set; }

    public int? TwIdOpakowanie { get; set; }

    public int? TwIdRabat { get; set; }

    public string TwSww { get; set; } = null!;

    public string TwPkwiU { get; set; } = null!;

    public string TwJednMiary { get; set; } = null!;

    public bool TwJakPrzySp { get; set; }

    public int? TwIdVatZak { get; set; }

    public int? TwIdVatSp { get; set; }

    public string TwOpis { get; set; } = null!;
}
