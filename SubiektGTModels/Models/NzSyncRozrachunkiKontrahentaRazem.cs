using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzSyncRozrachunkiKontrahentaRazem
{
    public int KontrahentId { get; set; }

    public DateTime DataPobrania { get; set; }

    public decimal? RazemNaleznosci { get; set; }

    public decimal? RazemSplatyNaleznosci { get; set; }

    public decimal? PersaldoNaleznosci { get; set; }

    public decimal? PersaldoRozrachunkow { get; set; }

    public decimal? RazemZobowiazania { get; set; }

    public decimal? RazemSplatyZobowiazan { get; set; }

    public decimal? PersaldoZobowiazan { get; set; }
}
