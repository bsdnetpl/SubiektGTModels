using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZestDefKontrahenci
{
    public int KhId { get; set; }

    public string KhSymbol { get; set; } = null!;

    public int? KhRodzaj { get; set; }

    public string? KhRegon { get; set; }

    public int? KhIdOdbiorca { get; set; }

    public string? KhKontakt { get; set; }

    public string? KhPesel { get; set; }

    public string? KhNrDowodu { get; set; }

    public DateTime? KhDataWyd { get; set; }

    public string? KhOrganWyd { get; set; }

    public bool? KhCentrumAut { get; set; }

    public bool? KhInstKredytowa { get; set; }

    public string? KhPrefKontakt { get; set; }

    public string? KhWww { get; set; }

    public string? KhEmail { get; set; }

    public int? KhIdGrupa { get; set; }

    public int? KhIdFormaP { get; set; }

    public int? KhCena { get; set; }

    public bool? KhPlatOdroczone { get; set; }

    public bool? KhOdbDet { get; set; }

    public int? KhIdRabat { get; set; }

    public int? KhMaxDokKred { get; set; }

    public decimal? KhMaxWartDokKred { get; set; }

    public decimal? KhMaxWartKred { get; set; }

    public int? KhMaxDniSp { get; set; }

    public string? KhNrAnalitykaD { get; set; }

    public string? KhNrAnalitykaO { get; set; }

    public string? KhUwagi { get; set; }

    public bool? KhZgodaDo { get; set; }

    public int? KhIdOsobaDo { get; set; }

    public bool? KhZgodaMark { get; set; }

    public bool? KhZgodaEmail { get; set; }

    public bool? KhCzyKomunikat { get; set; }

    public string? KhKomunikat { get; set; }

    public bool? KhKomunikatZawsze { get; set; }

    public DateTime? KhKomunikatOd { get; set; }

    public byte[]? KhGrafika { get; set; }

    public string? KhPole1 { get; set; }

    public string? KhPole2 { get; set; }

    public string? KhPole3 { get; set; }

    public string? KhPole4 { get; set; }

    public string? KhPole5 { get; set; }

    public string? KhPole6 { get; set; }

    public string? KhPole7 { get; set; }

    public string? KhPole8 { get; set; }

    public bool? KhJednorazowy { get; set; }

    public string? KhPracownik { get; set; }

    public bool? KhZablokowany { get; set; }

    public bool? KhAdresKoresp { get; set; }

    public bool? KhUpowaznienieVat { get; set; }

    public DateTime? KhDataVat { get; set; }

    public int? KhOsobaVat { get; set; }

    public decimal? KhProcKarta { get; set; }

    public decimal? KhProcKredyt { get; set; }

    public decimal? KhProcGotowka { get; set; }

    public decimal? KhProcPozostalo { get; set; }

    public int? KhIdKategoriaKh { get; set; }

    public int? KhIdEwVatsp { get; set; }

    public int? KhEwVatspMcOdliczenia { get; set; }

    public int? KhIdEwVatspKateg { get; set; }

    public int? KhIdEwVatzak { get; set; }

    public int? KhEwVatzakRodzaj { get; set; }

    public int? KhEwVatzakSposobOdliczenia { get; set; }

    public int? KhEwVatzakMcOdliczenia { get; set; }

    public int? KhIdEwVatzakKateg { get; set; }

    public int? KhIdRachKategPrzychod { get; set; }

    public int? KhIdRachKategRozchod { get; set; }

    public int? KhTransakcjaVatsp { get; set; }

    public int? KhTransakcjaVatzak { get; set; }

    public bool? KhPodVatzarejestrowanyWue { get; set; }

    public DateTime? KhDataWaznosciVat { get; set; }

    public string? KhOpisOperacji { get; set; }

    public bool? KhPlatPrzelew { get; set; }

    public int? AdrId { get; set; }

    public int? AdrIdObiektu { get; set; }

    public int? AdrTypAdresu { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public string AdrNazwaPelna { get; set; } = null!;

    public string? AdrTelefon { get; set; }

    public string? AdrFaks { get; set; }

    public string? AdrUlica { get; set; }

    public string? AdrNrDomu { get; set; }

    public string? AdrNrLokalu { get; set; }

    public string? AdrAdres { get; set; }

    public string? AdrKod { get; set; }

    public string? AdrMiejscowosc { get; set; }

    public int? AdrIdWojewodztwo { get; set; }

    public int? AdrIdPanstwo { get; set; }

    public string? AdrNip { get; set; }

    public string? AdrPoczta { get; set; }

    public string? AdrGmina { get; set; }

    public string? AdrPowiat { get; set; }

    public string? AdrSkrytka { get; set; }

    public string AdrSymbol { get; set; } = null!;

    public int? AdrIdGminy { get; set; }
}
