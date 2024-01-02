using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbTransakcjaOczekujacaObiekt
{
    public int HbtooId { get; set; }

    public int HbtooIdTransOczek { get; set; }

    public int HbtooTypObiektuPow { get; set; }

    public int HbtooIdObiektuPow { get; set; }

    public decimal HbtooWartosc { get; set; }

    public string HbtooWaluta { get; set; } = null!;

    public decimal? HbtooKurs { get; set; }

    public decimal? HbtooWartoscWaluta { get; set; }

    public virtual HbTransakcjaOczekujaca HbtooIdTransOczekNavigation { get; set; } = null!;
}
