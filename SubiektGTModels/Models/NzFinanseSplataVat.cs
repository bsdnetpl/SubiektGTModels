using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanseSplataVat
{
    public int NzvId { get; set; }

    public int NzvIdFinSplata { get; set; }

    public int NzvIdStawkiVat { get; set; }

    public decimal NzvNetto { get; set; }

    public decimal NzvKwotaVat { get; set; }

    public decimal NzvBrutto { get; set; }

    public virtual NzFinanseSplatum NzvIdFinSplataNavigation { get; set; } = null!;

    public virtual SlStawkaVat NzvIdStawkiVatNavigation { get; set; } = null!;
}
