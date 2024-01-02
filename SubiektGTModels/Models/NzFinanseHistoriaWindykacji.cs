using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanseHistoriaWindykacji
{
    public int HwId { get; set; }

    public DateTime HwData { get; set; }

    public int HwIdRozrachunku { get; set; }

    public string? HwOpis { get; set; }

    public int HwTyp { get; set; }

    public virtual NzFinanse HwIdRozrachunkuNavigation { get; set; } = null!;

    public virtual NzTypZdarzeniaWindykacyjnego HwTypNavigation { get; set; } = null!;
}
