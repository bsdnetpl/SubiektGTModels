using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbTransakcjaOczekujaca
{
    public int HbtoId { get; set; }

    public int HbtoIdObiektu { get; set; }

    public int? HbtoTypObiektu { get; set; }

    public int HbtoIdRachunkuBankowego { get; set; }

    public int HbtoIdRachunkuBankowegoKontrahenta { get; set; }

    public int HbtoTypZlecenia { get; set; }

    public DateTime? HbtoDataWyslania { get; set; }

    public DateTime? HbtoDataRealizacji { get; set; }

    public int? HbtoOplaty { get; set; }

    public string HbtoIdWaluty { get; set; } = null!;

    public decimal HbtoKwota { get; set; }

    public string? HbtoTytul { get; set; }

    public int HbtoStatus { get; set; }

    public int? HbtoStatusBank { get; set; }

    public int? HbtoIdHistoriiAdresu { get; set; }

    public int? HbtoIdRachunkuBankowegoKontrahentaHist { get; set; }

    public int? HbtoIdAdresu { get; set; }

    public string? HbtoWystawil { get; set; }

    public int HbtoIdWystawil { get; set; }

    public int? HbtoProgram { get; set; }

    public string? HbtoNazwaKontrahenta { get; set; }

    public bool HbtoTrybRealizacji { get; set; }

    public byte[]? HbtoPotwierdzenie { get; set; }

    public int? HbtoStatusPotwierdzenia { get; set; }

    public int? HbtoIdPrzedrostka { get; set; }

    public int? HbtoIdWbanku { get; set; }

    public string HbtoTypPrzelewu { get; set; } = null!;

    public string? HbtoZuspodIdentyfikator { get; set; }

    public string? HbtoZuspodTypIdentyfikatora { get; set; }

    public string? HbtoZustypWplaty { get; set; }

    public string? HbtoZusdeklaracja { get; set; }

    public string? HbtoZusnrDeklaracji { get; set; }

    public int? HbtoPodSymbol { get; set; }

    public string? HbtoPodIdentyfikacjaZobowiazania { get; set; }

    public string? HbtoPodOkres { get; set; }

    public string? HbtoZusnrDecyzji { get; set; }

    public int? HbtoRodzajSkladkiPlatZus { get; set; }

    public int HbtoIdPaczki { get; set; }

    public string? HbtoNrFaktury { get; set; }

    public decimal HbtoKwotaVat { get; set; }

    public int? HbtoPodtypTransakcji { get; set; }

    public string? HbtoNipkontrahenta { get; set; }

    public bool HbtoOczekujNaSrodki { get; set; }

    public virtual ICollection<HbRaport> HbRaports { get; set; } = new List<HbRaport>();

    public virtual ICollection<HbTransakcjaOczekujacaObiekt> HbTransakcjaOczekujacaObiekts { get; set; } = new List<HbTransakcjaOczekujacaObiekt>();

    public virtual AdrEwid? HbtoIdAdresuNavigation { get; set; }

    public virtual AdrHistorium? HbtoIdHistoriiAdresuNavigation { get; set; }

    public virtual HbPrzedrostekHist? HbtoIdPrzedrostkaNavigation { get; set; }

    public virtual RbRachBankowyHistorium? HbtoIdRachunkuBankowegoKontrahentaHistNavigation { get; set; }

    public virtual RbRachBankowy HbtoIdRachunkuBankowegoKontrahentaNavigation { get; set; } = null!;

    public virtual RbRachBankowy HbtoIdRachunkuBankowegoNavigation { get; set; } = null!;

    public virtual SlWalutum HbtoIdWalutyNavigation { get; set; } = null!;
}
