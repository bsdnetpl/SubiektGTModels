using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpAbsencjaPrzedKorektum
{
    public int EcpapkId { get; set; }

    public int EcpapkIdZapis { get; set; }

    public int EcpapkRodzaj { get; set; }

    public string? EcpapkKodPrzerwy { get; set; }

    public string? EcpapkKodChoroby { get; set; }

    public string? EcpapkNrZwolnienia { get; set; }

    public string? EcpapkNrChoroby { get; set; }

    public decimal? EcpapkProcent { get; set; }

    public bool? EcpapkWypadek { get; set; }

    public bool? EcpapkUrlopNaZadanie { get; set; }

    public int? EcpapkMiesSkladStale { get; set; }

    public int? EcpapkMiesSkladZmienne { get; set; }

    public int? EcpapkOpisAbsencji { get; set; }

    public decimal? EcpapkWspolczynnikWaloryzacji { get; set; }

    public bool? EcpapkPierwotnie3xx { get; set; }

    public decimal? EcpapkPodstawaUrlWych { get; set; }

    public bool EcpapkOpiekaNadDzieckiemGodzinowo { get; set; }

    public bool EcpapkPodwyzszenieDoKwotySwiadczenia { get; set; }

    public DateTime? EcpapkDataWplynieciaZwolnienia { get; set; }

    public DateTime? EcpapkDataZlozeniaWniosku { get; set; }

    public int? EcpapkIdDziecka { get; set; }

    public decimal? EcpapkPodstawaZasilku { get; set; }

    public virtual PrRodzina? EcpapkIdDzieckaNavigation { get; set; }

    public virtual SlOpisAbsencji? EcpapkOpisAbsencjiNavigation { get; set; }
}
