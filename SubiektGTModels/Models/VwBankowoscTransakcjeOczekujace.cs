using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwBankowoscTransakcjeOczekujace
{
    public int Ident { get; set; }

    public int IdObiektu { get; set; }

    public int? TypObiektu { get; set; }

    public string? NazwaKontrahenta { get; set; }

    public int TypZlecenia { get; set; }

    public DateTime? DataWyslania { get; set; }

    public DateTime? DataRealizacji { get; set; }

    public int? OplatyKto { get; set; }

    public int? Program { get; set; }

    public string? Waluta { get; set; }

    public decimal Kwota { get; set; }

    public decimal Vat { get; set; }

    public string? Tytul { get; set; }

    public string? NrFaktury { get; set; }

    public int StatusTransakcji { get; set; }

    public int? StatusBank { get; set; }

    public string? NumerRachunkuNaszego { get; set; }

    public string? NumerRachunkuKontrahenta { get; set; }

    public string? NumerRachunkuKontrahentaHist { get; set; }

    public int? IdRachunkuPodmiotu { get; set; }

    public string? IdentBank { get; set; }

    public string? AdresKontrahenta { get; set; }

    public int? AdrhId { get; set; }

    public string? Nippeselkontrahenta { get; set; }

    public string? SymbolKontrahenta { get; set; }

    public string? NazwaDoPrzelewu { get; set; }

    public string? Wystawil { get; set; }

    public DateTime? HbDataKsiegowania { get; set; }

    public DateTime? HbDataWaluty { get; set; }

    public string? IdentPaczki { get; set; }

    public int? IdRachunkuKontrahenta { get; set; }

    public bool? KhrNaBialejLiscie { get; set; }

    public DateTime? KhrDataWeryfikacji { get; set; }
}
