using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefFaktury
{
    public int KsefId { get; set; }

    public DateTime? KsefDataPobrania { get; set; }

    public DateTime? KsefDataWystawienia { get; set; }

    public string? KsefNumer { get; set; }

    public string? KsefNumerKseF { get; set; }

    public DateTime? KsefDataNumeruKseF { get; set; }

    public string? KsefNip { get; set; }

    public string? KsefKontrahent { get; set; }

    public decimal? KsefWartoscBrutto { get; set; }

    public string? KsefWaluta { get; set; }

    public int KsefStatusPrzetworzenia { get; set; }

    public int? KsefIdPlik { get; set; }

    public int KsefZrodlo { get; set; }

    public string? KsefRodzaj { get; set; }

    public string? KsefNumerKseFkorygowanej { get; set; }

    public string? KsefNip2 { get; set; }

    public string? KsefBladKseF { get; set; }

    public int KsefStatusBledu { get; set; }

    public int KsefWersja { get; set; }

    public string? KsefNumerFaKorygowanej { get; set; }

    public bool KsefUzytoModyfikacjiWlasnej { get; set; }

    public string? KsefDataNumeruKseForyg { get; set; }

    public virtual ICollection<KsefFakturyHandel> KsefFakturyHandels { get; set; } = new List<KsefFakturyHandel>();

    public virtual ICollection<KsefFakturyKsiegowosc> KsefFakturyKsiegowoscs { get; set; } = new List<KsefFakturyKsiegowosc>();

    public virtual KsefPliki? KsefIdPlikNavigation { get; set; }
}
