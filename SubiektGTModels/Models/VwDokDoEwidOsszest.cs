using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokDoEwidOsszest
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? DokMagId { get; set; }

    public int DokStatus { get; set; }

    public int DokRodzajOperacjiVat { get; set; }

    public DateTime DokDataWyst { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public DateTime DokDataMag { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public string? DokKhSymbol { get; set; }

    public string? DokKhNazwa { get; set; }

    public string? DokKhAdres { get; set; }

    public string? DokKhMiejscowosc { get; set; }

    public int? DokIdPanstwoKonsumenta { get; set; }

    public string? DokPanstwoKonsumenta { get; set; }

    public string? DokPanstwoWysylki { get; set; }

    public string? DokKhGrupa { get; set; }

    public decimal? DokWartNettoWaluta { get; set; }

    public decimal? DokWartNetto { get; set; }

    public decimal? DokWartBruttoWaluta { get; set; }

    public decimal? DokWartBrutto { get; set; }

    public decimal? DokWartVatWaluta { get; set; }

    public decimal? DokWartVat { get; set; }

    public string? DokWaluta { get; set; }

    public string? DokInformacjeDodatkowe { get; set; }

    public string? DokOznaczeniaJpk { get; set; }

    public bool? DojSw { get; set; }

    public bool? DojEe { get; set; }

    public bool? DojWstoEe { get; set; }
}
