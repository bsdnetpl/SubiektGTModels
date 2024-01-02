using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwTowaryTransakcji
{
    public int? TwId { get; set; }

    public int? ObStatus { get; set; }

    public int? ObDokHanLp { get; set; }

    public int? ObDokMagLp { get; set; }

    public int ObTowRodzaj { get; set; }

    public string? ObTowSymbol { get; set; }

    public string? ObTowSymbolDost { get; set; }

    public string? ObTowNazwa { get; set; }

    public string? ObTowPkwiu { get; set; }

    public string? ObTowOpis { get; set; }

    public string? ObOpis { get; set; }

    public DateTime? ObTermin { get; set; }

    public decimal ObIlosc { get; set; }

    public string? ObJm { get; set; }

    public string? ObIloscJm { get; set; }

    public string? ObWaluta { get; set; }

    public decimal? ObCenaNetto { get; set; }

    public decimal? ObCenaBrutto { get; set; }

    public decimal ObRabat { get; set; }

    public decimal? ObCenaNettoPoRabacie { get; set; }

    public decimal? ObCenaBruttoPoRabacie { get; set; }

    public decimal? ObVatProc { get; set; }

    public decimal? ObWartNettoPrzedRabatem { get; set; }

    public decimal? ObWartVatPrzedRabatem { get; set; }

    public decimal? ObWartBruttoPrzedRabatem { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartVat { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public int ObId { get; set; }

    public int? ObDoId { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public int? ObTowId { get; set; }

    public decimal ObIloscMag { get; set; }

    public decimal ObCenaMag { get; set; }

    public decimal ObCenaWaluta { get; set; }

    public decimal ObWartMag { get; set; }

    public int? ObGrupaId { get; set; }

    public short ObZnak { get; set; }

    public decimal? ObStan { get; set; }

    public int? ObMagId { get; set; }

    public string? ObNumerSeryjny { get; set; }

    public decimal? ObTowObjetosc { get; set; }

    public decimal? ObTowMasa { get; set; }

    public decimal? ObObjetosc { get; set; }

    public decimal? ObMasa { get; set; }

    public string? ObKategoria { get; set; }

    public int? ObVatId { get; set; }

    public int? ObKategoriaId { get; set; }

    public int? ObIdOpakowanie { get; set; }

    public int? ObIdDoZdj { get; set; }

    public int? ObTowFlgNumer { get; set; }
}
