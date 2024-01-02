using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwTowar
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

    public bool TwOplCukrowaPodlega { get; set; }

    public decimal? TwOplCukrowaObj { get; set; }

    public decimal? TwOplCukrowaZawartoscCukru { get; set; }

    public bool TwOplCukrowaInneSlodzace { get; set; }

    public bool TwOplCukrowaSok { get; set; }

    public decimal? TwOplCukrowaKwota { get; set; }

    public bool TwOplCukrowaKofeinaPodlega { get; set; }

    public decimal? TwOplCukrowaKofeinaKwota { get; set; }

    public bool TwOplCukrowaNapojWeglElektr { get; set; }

    public decimal? TwOplCukrowaKwotaPowyzej { get; set; }

    public decimal? TwMasaNetto { get; set; }

    public int? TwIdKoduWyrobuAkcyzowego { get; set; }

    public string TwAkcyzaMarkaWyrobow { get; set; } = null!;

    public string TwAkcyzaWielkoscProducenta { get; set; } = null!;

    public int? TwZnakiAkcyzy { get; set; }

    public DateTime? TwDataZmianyVatSprzedazy { get; set; }

    public bool TwWegielPodlegaOswiadczeniu { get; set; }

    public string TwWegielOpisPochodzenia { get; set; } = null!;

    public bool TwPodlegaOplacieNaFunduszOchronyRolnictwa { get; set; }

    public virtual ICollection<DfwPozycja> DfwPozycjas { get; set; } = new List<DfwPozycja>();

    public virtual ICollection<DokPozycja> DokPozycjas { get; set; } = new List<DokPozycja>();

    public virtual ICollection<IcenCennikTowar> IcenCennikTowars { get; set; } = new List<IcenCennikTowar>();

    public virtual ICollection<IdxTwTowar> IdxTwTowars { get; set; } = new List<IdxTwTowar>();

    public virtual ICollection<TwTowar> InverseTwIdOpakowanieNavigation { get; set; } = new List<TwTowar>();

    public virtual ICollection<IwPozycja> IwPozycjas { get; set; } = new List<IwPozycja>();

    public virtual LenTwTowar? LenTwTowar { get; set; }

    public virtual ICollection<MiMapaAsortyment> MiMapaAsortymentMimIdTowaruNavigations { get; set; } = new List<MiMapaAsortyment>();

    public virtual ICollection<MiMapaAsortyment> MiMapaAsortymentMimIdTowaruPromocyjnegoNavigations { get; set; } = new List<MiMapaAsortyment>();

    public virtual SlModelTowar? SlModelTowar { get; set; }

    public virtual ICollection<TwCechaTw> TwCechaTws { get; set; } = new List<TwCechaTw>();

    public virtual TwCena? TwCena { get; set; }

    public virtual ICollection<TwCenaHistorium> TwCenaHistoria { get; set; } = new List<TwCenaHistorium>();

    public virtual ICollection<TwDokument> TwDokuments { get; set; } = new List<TwDokument>();

    public virtual SlGrupaTw? TwIdGrupaNavigation { get; set; }

    public virtual SlKodWyrobuAkcyzowego? TwIdKoduWyrobuAkcyzowegoNavigation { get; set; }

    public virtual SlKrajPochodzenium? TwIdKrajuPochodzeniaNavigation { get; set; }

    public virtual TwTowar? TwIdOpakowanieNavigation { get; set; }

    public virtual KhKontrahent? TwIdPodstDostawcaNavigation { get; set; }

    public virtual KhKontrahent? TwIdProducentaNavigation { get; set; }

    public virtual SlRabat? TwIdRabatNavigation { get; set; }

    public virtual SlStawkaVat? TwIdVatSpNavigation { get; set; }

    public virtual SlStawkaVat? TwIdVatZakNavigation { get; set; }

    public virtual ICollection<TwJednMiary> TwJednMiaries { get; set; } = new List<TwJednMiary>();

    public virtual ICollection<TwKodKreskowy> TwKodKreskowies { get; set; } = new List<TwKodKreskowy>();

    public virtual ICollection<TwKomplet> TwKomplets { get; set; } = new List<TwKomplet>();

    public virtual ICollection<TwOpakowaniaAkcyzowe> TwOpakowaniaAkcyzowes { get; set; } = new List<TwOpakowaniaAkcyzowe>();

    public virtual ICollection<TwStan> TwStans { get; set; } = new List<TwStan>();

    public virtual ICollection<TwZdjecieTw> TwZdjecieTws { get; set; } = new List<TwZdjecieTw>();

    public virtual ICollection<TwZmiana> TwZmianas { get; set; } = new List<TwZmiana>();

    public virtual ICollection<UfPlu> UfPlus { get; set; } = new List<UfPlu>();
}
