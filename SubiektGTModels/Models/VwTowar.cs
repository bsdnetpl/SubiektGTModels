using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwTowar
{
    public int TwId { get; set; }

    public bool TwZablokowany { get; set; }

    public int TwRodzaj { get; set; }

    public string TwSymbol { get; set; } = null!;

    public string TwNazwa { get; set; } = null!;

    public int? StTowId { get; set; }

    public int? StMagId { get; set; }

    public decimal? StStan { get; set; }

    public decimal? Stan { get; set; }

    public decimal? Rezerwacja { get; set; }

    public decimal? Dostepne { get; set; }

    public decimal? StStanMin { get; set; }

    public decimal? TwStanMin { get; set; }

    public string TwJednMiary { get; set; } = null!;

    public string TwOpis { get; set; } = null!;

    public int? TwIdVatSp { get; set; }

    public int? TwIdVatZak { get; set; }

    public string? VatSymbol { get; set; }

    public bool TwJakPrzySp { get; set; }

    public string TwPkwiU { get; set; } = null!;

    public string TwSww { get; set; } = null!;

    public int? TwPlu { get; set; }

    public int? TwIdRabat { get; set; }

    public int? TwIdOpakowanie { get; set; }

    public bool TwPrzezWartosc { get; set; }

    public int? TwIdPodstDostawca { get; set; }

    public string? Dostawca { get; set; }

    public string TwDostSymbol { get; set; } = null!;

    public int? TwCzasDostawy { get; set; }

    public string TwUrzNazwa { get; set; } = null!;

    public string TwPodstKodKresk { get; set; } = null!;

    public int? TwIdTypKodu { get; set; }

    public bool TwCenaOtwarta { get; set; }

    public bool? TwWagaEtykiet { get; set; }

    public int? TwDniWaznosc { get; set; }

    public int? TwIdGrupa { get; set; }

    public string TwUwagi { get; set; } = null!;

    public string TwWww { get; set; } = null!;

    public bool TwSklepInternet { get; set; }

    public string? TwCharakter { get; set; }

    public byte[]? TwLogo { get; set; }

    public bool TwSerwisAukcyjny { get; set; }

    public decimal? TcCenaNetto1 { get; set; }

    public decimal? TcCenaNetto2 { get; set; }

    public decimal? TcCenaNetto3 { get; set; }

    public decimal? TcCenaNetto4 { get; set; }

    public decimal? TcCenaNetto5 { get; set; }

    public decimal? TcCenaNetto6 { get; set; }

    public decimal? TcCenaNetto7 { get; set; }

    public decimal? TcCenaNetto8 { get; set; }

    public decimal? TcCenaNetto9 { get; set; }

    public decimal? TcCenaNetto10 { get; set; }

    public decimal? TcCenaBrutto1 { get; set; }

    public decimal? TcCenaBrutto2 { get; set; }

    public decimal? TcCenaBrutto3 { get; set; }

    public decimal? TcCenaBrutto4 { get; set; }

    public decimal? TcCenaBrutto5 { get; set; }

    public decimal? TcCenaBrutto6 { get; set; }

    public decimal? TcCenaBrutto7 { get; set; }

    public decimal? TcCenaBrutto8 { get; set; }

    public decimal? TcCenaBrutto9 { get; set; }

    public decimal? TcCenaBrutto10 { get; set; }

    public int? TcIdTowar { get; set; }

    public decimal? TcZysk1 { get; set; }

    public decimal? TcZysk2 { get; set; }

    public decimal? TcZysk3 { get; set; }

    public decimal? TcZysk4 { get; set; }

    public decimal? TcZysk5 { get; set; }

    public decimal? TcZysk6 { get; set; }

    public decimal? TcZysk7 { get; set; }

    public decimal? TcZysk8 { get; set; }

    public decimal? TcZysk9 { get; set; }

    public decimal? TcZysk10 { get; set; }

    public decimal? TcNarzut1 { get; set; }

    public decimal? TcNarzut2 { get; set; }

    public decimal? TcNarzut3 { get; set; }

    public decimal? TcNarzut4 { get; set; }

    public decimal? TcNarzut5 { get; set; }

    public decimal? TcNarzut6 { get; set; }

    public decimal? TcNarzut7 { get; set; }

    public decimal? TcNarzut8 { get; set; }

    public decimal? TcNarzut9 { get; set; }

    public decimal? TcNarzut10 { get; set; }

    public decimal? TcMarza1 { get; set; }

    public decimal? TcMarza2 { get; set; }

    public decimal? TcMarza3 { get; set; }

    public decimal? TcMarza4 { get; set; }

    public decimal? TcMarza5 { get; set; }

    public decimal? TcMarza6 { get; set; }

    public decimal? TcMarza7 { get; set; }

    public decimal? TcMarza8 { get; set; }

    public decimal? TcMarza9 { get; set; }

    public decimal? TcMarza10 { get; set; }

    public string? TcIdWaluta1 { get; set; }

    public string? TcIdWaluta2 { get; set; }

    public string? TcIdWaluta3 { get; set; }

    public string? TcIdWaluta4 { get; set; }

    public string? TcIdWaluta5 { get; set; }

    public string? TcIdWaluta6 { get; set; }

    public string? TcIdWaluta7 { get; set; }

    public string? TcIdWaluta8 { get; set; }

    public string? TcIdWaluta9 { get; set; }

    public string? TcIdWaluta10 { get; set; }

    public decimal? TcCenaNetto0 { get; set; }

    public string? TcWalutaId { get; set; }

    public decimal? TcWalutaKurs { get; set; }

    public int? TcPodstawaKc { get; set; }

    public decimal? TcCenaNettoWaluta { get; set; }

    public string? TcWalutaJedn { get; set; }

    public string TwPole1 { get; set; } = null!;

    public string TwPole2 { get; set; } = null!;

    public string TwPole3 { get; set; } = null!;

    public string TwPole4 { get; set; } = null!;

    public string TwPole5 { get; set; } = null!;

    public string TwPole6 { get; set; } = null!;

    public string TwPole7 { get; set; } = null!;

    public string TwPole8 { get; set; } = null!;

    public bool TwSprzedazMobilna { get; set; }

    public decimal? TwWysokosc { get; set; }

    public decimal? TwSzerokosc { get; set; }

    public decimal? TwGlebokosc { get; set; }

    public decimal? TwStanMaks { get; set; }

    public bool TwObrotMarza { get; set; }

    public bool TwOdwrotneObciazenie { get; set; }

    public bool TwMechanizmPodzielonejPlatnosci { get; set; }

    public string? TwKodTowaru { get; set; }

    public int TwGrupaJpkVat { get; set; }

    public bool TwOplCukrowaPodlega { get; set; }

    public bool TwOplCukrowaKofeinaPodlega { get; set; }
}
