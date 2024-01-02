using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRozliczeniaSzybkichPlatnosci
{
    public int Id { get; set; }

    public int StatusTransakcji { get; set; }

    public DateTime? DataTransakcji { get; set; }

    public string TransId { get; set; } = null!;

    public decimal KwotaTransakcji { get; set; }

    public decimal Prowizja { get; set; }

    public decimal? KwotaSplatyTransakcji { get; set; }

    public string? OpisTransakcji { get; set; }

    public int? IdPliku { get; set; }

    public string? NazwaPliku { get; set; }

    public int? IdSubkonta { get; set; }

    public int? IdPosrednika { get; set; }

    public string? SymbolPosrednika { get; set; }

    public string? NazwaPosrednika { get; set; }

    public int? IdNaleznosci { get; set; }

    public string? NumerNaleznosci { get; set; }

    public DateTime? DataNaleznosci { get; set; }

    public decimal? KwotaPierwotnaNaleznosci { get; set; }

    public decimal? KwotaRozliczeniaNaleznosci { get; set; }

    public decimal? KwotaPozostalo { get; set; }

    public int? IdOperacji { get; set; }

    public DateTime? DataOperacji { get; set; }

    public string? TytulOperacji { get; set; }

    public string? OpisOperacji { get; set; }

    public decimal? KwotaPierwotnaOperacji { get; set; }

    public decimal? KwotaRozliczeniaOperacji { get; set; }

    public DateTime? DataSplaty { get; set; }

    public string? NumerSplaty { get; set; }

    public decimal? KwotaPierwotnaSplaty { get; set; }

    public decimal? KwotaRozliczeniaSplaty { get; set; }
}
