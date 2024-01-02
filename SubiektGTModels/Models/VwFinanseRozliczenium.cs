using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozliczenium
{
    public int IdRozliczenia { get; set; }

    public int TypRozliczenia { get; set; }

    public int? IdRozrachunku { get; set; }

    public int? TypRozrachunku { get; set; }

    public string? NrPelnyRozrachunku { get; set; }

    public DateTime? DataRozrachunku { get; set; }

    public int? StatusRozliczeniaRozrachunku { get; set; }

    public int? IdSplaty { get; set; }

    public int? TypSplaty { get; set; }

    public string? NrPelnySplaty { get; set; }

    public DateTime? DataSplaty { get; set; }

    public int? StatusRozliczeniaSplaty { get; set; }

    public decimal KwotaRozliczeniaWaluta { get; set; }

    public string WalutaRozliczenia { get; set; } = null!;

    public decimal? KwotaRozliczeniaPln { get; set; }

    public string? NrPelnyRozliczenia { get; set; }

    public DateTime DataRozliczenia { get; set; }

    public int? IdHistAdresu { get; set; }

    public string? KontrahentSymbol { get; set; }

    public string? KontrahentNazwa { get; set; }

    public string? KontoRozrachunku { get; set; }

    public string? KontoSplaty { get; set; }

    public int? KategoriaRozrachunku { get; set; }

    public int? KategoriaSplaty { get; set; }

    public decimal? WartoscPierwotnaRozrachunkuPln { get; set; }

    public decimal? WartoscRozrachunkuPln { get; set; }

    public decimal? WartoscPierwotnaSplatyPln { get; set; }

    public decimal? WartoscSplatyPln { get; set; }

    public int? JestVat { get; set; }

    public int StatusKsiegowy { get; set; }

    public int? KategoriaRozliczenia { get; set; }

    public int? IdOznaczenJpkVat { get; set; }

    public int? IdDokumentuHandlowego { get; set; }
}
