using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanseNotum
{
    public int NoId { get; set; }

    public int NoIdRozrachunku { get; set; }

    public int NoIdNoty { get; set; }

    public decimal NoWartoscWalutaOdsetek { get; set; }

    public string? NoOpis { get; set; }

    public DateTime NoData { get; set; }

    public int NoStatusKsiegowy { get; set; }

    public int? NoIdKategorii { get; set; }

    public virtual SlKategorium? NoIdKategoriiNavigation { get; set; }

    public virtual NzFinanse NoIdNotyNavigation { get; set; } = null!;

    public virtual NzFinanse NoIdRozrachunkuNavigation { get; set; } = null!;
}
