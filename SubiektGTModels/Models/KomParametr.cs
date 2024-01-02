using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KomParametr
{
    public int KomId { get; set; }

    public int KomTypPodmiotu { get; set; }

    public int KomIdMagazyn { get; set; }

    public bool KomCenyZakupu { get; set; }

    public bool KomKhAktualizuj { get; set; }

    public bool KomTwAktualizuj { get; set; }

    public int KomOdbior { get; set; }

    public bool KomDoBiuraWszyscyKh { get; set; }

    public bool KomDoBiuraOpGotowkowe { get; set; }

    public bool KomDoBiuraOpBezKh { get; set; }

    public bool KomBiuroKhNip { get; set; }

    public bool KomBiuroKhDodaj { get; set; }

    public string KomSymbol { get; set; } = null!;

    public int KomNr { get; set; }

    public bool KomDoBiuraMagazynoweKhWirtual { get; set; }

    public int KomKhTypAktualizacji { get; set; }

    public int KomTwTypAktualizacji { get; set; }

    public bool KomBiuroPrDodaj { get; set; }

    public bool KomPrAktualizuj { get; set; }

    public bool KomNieMarzaZyskKoszt { get; set; }

    public int KomOchronaDanychOsobowych { get; set; }

    public bool KomSzyfrujPlikiEdipp { get; set; }

    public string? KomHasloEdippeksport { get; set; }

    public string? KomHasloEdippimport { get; set; }

    public bool KomSzyfrujPlikiEbisxml { get; set; }

    public string? KomHasloEbisxmleksport { get; set; }

    public string? KomHasloEbisxmlimport { get; set; }

    public bool KomSzyfrujPlikiKadryPlaceXmleksport { get; set; }

    public bool KomSzyfrujPlikiKadryPlaceXmlimport { get; set; }

    public string? KomHasloKadryPlaceXmleksport { get; set; }

    public string? KomHasloKadryPlaceXmlimport { get; set; }

    public bool KomNieWysylajDanychWrazliwychEdipp { get; set; }

    public bool KomNieWysylajDanychWrazliwychEbisxml { get; set; }

    public bool KomNieWysylajDanychWrazliwychPozostale { get; set; }

    public int KomDoBiuraDataSprzedaz { get; set; }

    public int KomDoBiuraDataSprzedazKorekta { get; set; }

    public int KomDoBiuraDataZakup { get; set; }

    public int KomDoBiuraDataZakupKorekta { get; set; }
}
