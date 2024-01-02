using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefParametry
{
    public int KsefpId { get; set; }

    public int KsefpParamEwidId { get; set; }

    public bool KsefpZapisujDokumentyWbazie { get; set; }

    public int? KsefpSrodowisko { get; set; }

    public int KsefpTrybWysylki { get; set; }

    public int KsefpOdswiezanieStatusowInterwal { get; set; }

    public int KsefpPobieranieFakturInterwal { get; set; }

    public bool KsefpOdswiezajStatusy { get; set; }

    public bool KsefpPobierajMojeFaktury { get; set; }

    public bool KsefpPobierajInneFaktury { get; set; }

    public DateTime? KsefpMojeFakturyOd { get; set; }

    public DateTime? KsefpInneFakturyOd { get; set; }

    public int KsefpPlatnoscKartaWysylajJako { get; set; }

    public int KsefpPlatnoscKredytWysylajJako { get; set; }

    public int KsefpPlatnoscPrzelewWysylajJako { get; set; }

    public int KsefpBrakNabywcyZachowanie { get; set; }

    public int KsefpNiezgodneDaneNabywcyZachowanie { get; set; }

    public int KsefpMapaPowiazanTowarowych { get; set; }

    public int KsefpMapaJednostekMiar { get; set; }

    public int KsefpImportObslugaPolaDodatkoweInformacje { get; set; }

    public int KsefpEksportObslugaPolaDodatkoweInformacje { get; set; }

    public string? KsefpKartaMapujNaInnaOpis { get; set; }

    public string? KsefpKredytMapujNaInnaOpis { get; set; }

    public string? KsefpPrzelewMapujNaInnaOpis { get; set; }

    public int KsefpWysylkaPoZapisie { get; set; }

    public int KsefpGotowkaWczytajJako { get; set; }

    public int KsefpKartaWczytajJako { get; set; }

    public int KsefpBonWczytajJako { get; set; }

    public int KsefpCzekWczytajJako { get; set; }

    public int KsefpKredytWczytajJako { get; set; }

    public int KsefpPrzelewWczytajJako { get; set; }

    public int KsefpMobilnaWczytajJako { get; set; }

    public int KsefpInnaWczytajJako { get; set; }

    public int KsefpBezFormyPlatnosciWczytajJako { get; set; }

    public int KsefpBezSekcjiPlatnosciWczytajJako { get; set; }

    public int KsefpFormaPlatnosciFakturNiezaplaconych { get; set; }

    public DateTime? KsefpMojeFakturyOstatnie { get; set; }

    public DateTime? KsefpInneFakturyOstatnie { get; set; }

    public int KsefpPobieranieFakturInterwalDlugi { get; set; }

    public bool KsefpPobierajFaktury { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatGotowka { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatKarta { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatBon { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatCzek { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatKredyt { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatPrzelew { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatMobilna { get; set; }

    public int KsefpKartaWybranaDlaWczytanejFplatInna { get; set; }

    public int KsefpKartaWybranaDlaWczytanejBezFplat { get; set; }

    public int KsefpKartaWybranaDlaWczytanejBezSekPlat { get; set; }

    public int? KsefpWybranyMagazyn { get; set; }

    public bool KsefpPobierajFakturyPrzyStarcie { get; set; }

    public int KsefpGenerujPoZapisie { get; set; }

    public bool KsefpSprawdzajPrzedZapisem { get; set; }

    public bool KsefpEksportDodatkoweInfoPoprzedzEtykietaPola { get; set; }

    public int KsefpInformacjeOplatnosciach { get; set; }

    public int KsefpVatDlaFakturVatMarza { get; set; }

    public DateTime? KsefpOdswiezanieStatusowOstatnie { get; set; }

    public bool KsefpPobierajUpo { get; set; }

    public int KsefpPobierajUpointerwal { get; set; }

    public DateTime? KsefpPobierajUpoostatnie { get; set; }

    public string? KsefpEksportDodatkoweInfoSql { get; set; }

    public bool KsefpEksportDodatkoweInfoNaPodstSql { get; set; }

    public int KsefpPozycjeZeFakturZalWczytajJako { get; set; }

    public bool KsefpUstawiajPodtytulDokJakoFakturaKorekta { get; set; }

    public bool KsefpNumeryPoprzednichFakturZalWuwagach { get; set; }

    public bool KsefpLogowanie { get; set; }

    public int KsefpLogowaniePoziom { get; set; }

    public bool KsefpPobierajFakturySprzedazowe { get; set; }

    public DateTime? KsefpFakturySprzedazoweOd { get; set; }

    public DateTime? KsefpFakturySprzedazoweOstatnie { get; set; }

    public int KsefpEtapPrzetwarzaniaNabywca { get; set; }

    public int KsefpEtapPrzetwarzaniaSprzedawca { get; set; }

    public int KsefpImportNierozpoznanyAsortyment { get; set; }

    public DateTime? KsefpMojeFakturyOdOstatnie { get; set; }

    public DateTime? KsefpInneFakturyOdOstatnie { get; set; }

    public DateTime? KsefpFakturySprzedazoweOdOstatnie { get; set; }

    public virtual ParEwid KsefpParamEwid { get; set; } = null!;

    public virtual SlMagazyn? KsefpWybranyMagazynNavigation { get; set; }
}
