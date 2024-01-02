using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpAbsencja
{
    public int EcpaId { get; set; }

    public int EcpaIdZapis { get; set; }

    public int EcpaRodzaj { get; set; }

    public string? EcpaKodPrzerwy { get; set; }

    public string? EcpaKodChoroby { get; set; }

    public string? EcpaNrZwolnienia { get; set; }

    public string? EcpaNrChoroby { get; set; }

    public decimal? EcpaProcent { get; set; }

    public bool? EcpaWypadek { get; set; }

    public bool? EcpaUrlopNaZadanie { get; set; }

    public int? EcpaMiesSkladStale { get; set; }

    public int? EcpaMiesSkladZmienne { get; set; }

    public int? EcpaOpisAbsencji { get; set; }

    public decimal? EcpaWspolczynnikWaloryzacji { get; set; }

    public bool? EcpaPierwotnie3xx { get; set; }

    public decimal? EcpaPodstawaUrlWych { get; set; }

    public bool EcpaOpiekaNadDzieckiemGodzinowo { get; set; }

    public bool EcpaPodwyzszenieDoKwotySwiadczenia { get; set; }

    public DateTime? EcpaDataWplynieciaZwolnienia { get; set; }

    public DateTime? EcpaDataZlozeniaWniosku { get; set; }

    public int? EcpaIdDziecka { get; set; }

    public bool EcpaPochodzenieEzla { get; set; }

    public bool EcpaNaliczajPrzestojoweProcent { get; set; }

    public int? EcpaProcentPrzestojowego { get; set; }

    public decimal? EcpaPodstawaZasilku { get; set; }

    public int EcpaLiczbaMinutUrlopu { get; set; }

    public bool EcpaUrlopSilaWyzszaGodzinowo { get; set; }

    public int EcpaLiczbaMinutUrlopuSilaWyzsza { get; set; }

    public virtual PrRodzina? EcpaIdDzieckaNavigation { get; set; }

    public virtual SlOpisAbsencji? EcpaOpisAbsencjiNavigation { get; set; }
}
