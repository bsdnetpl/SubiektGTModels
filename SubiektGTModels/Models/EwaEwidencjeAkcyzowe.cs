using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EwaEwidencjeAkcyzowe
{
    public int EwaId { get; set; }

    public int EwaTyp { get; set; }

    public bool EwaBufor { get; set; }

    public int? EwaGrupa { get; set; }

    public int? EwaKorektaDoId { get; set; }

    public int? EwaPozId { get; set; }

    public int? EwaDokId { get; set; }

    public DateTime? EwaDataWystawienia { get; set; }

    public DateTime? EwaDataSprzedazy { get; set; }

    public DateTime? EwaDataWydania { get; set; }

    public string? EwaDokNrPelny { get; set; }

    public int? EwaKhId { get; set; }

    public string? EwaKhSymbol { get; set; }

    public string? EwaKhPesel { get; set; }

    public string? EwaKhNazwa { get; set; }

    public string? EwaKhAdrUlica { get; set; }

    public string? EwaKhAdrNrDomu { get; set; }

    public string? EwaKhAdrNrLokalu { get; set; }

    public string? EwaKhAdres { get; set; }

    public string? EwaKhKod { get; set; }

    public string? EwaKhMiejscowosc { get; set; }

    public string? EwaKhNip { get; set; }

    public int? EwaTwId { get; set; }

    public string? EwaTwSymbol { get; set; }

    public string? EwaTwNazwa { get; set; }

    public string? EwaTwKodTowaru { get; set; }

    public decimal? EwaIlosc { get; set; }

    public decimal? EwaWartoscNetto { get; set; }

    public decimal? EwaWartoscBrutto { get; set; }

    public decimal? EwaWartoscAkcyzy { get; set; }

    public int? EwaPowodZwolnieniaId { get; set; }

    public string? EwaPowodZwolnieniaNazwa { get; set; }

    public int EwaMagId { get; set; }

    public bool EwaKorygowana { get; set; }

    public string? EwaWystawilKorekte { get; set; }

    public DateTime? EwaDataKorekty { get; set; }

    public string? EwaKorektaAdnotacja { get; set; }
}
