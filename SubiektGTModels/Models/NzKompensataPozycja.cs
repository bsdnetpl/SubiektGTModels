using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzKompensataPozycja
{
    public int NzpId { get; set; }

    public int NzpIdKompensaty { get; set; }

    public int NzpIdRozrachunku { get; set; }

    public decimal NzpKwota { get; set; }

    public virtual NzKompensatum NzpIdKompensatyNavigation { get; set; } = null!;

    public virtual NzFinanse NzpIdRozrachunkuNavigation { get; set; } = null!;
}
