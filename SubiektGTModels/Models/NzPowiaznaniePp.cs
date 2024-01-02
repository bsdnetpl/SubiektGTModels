using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzPowiaznaniePp
{
    public int NzpIdGlownyPp { get; set; }

    public int NzpIdTechnicznyVat { get; set; }

    public int NzpTypPowiazania { get; set; }

    public virtual NzFinanse NzpIdGlownyPpNavigation { get; set; } = null!;

    public virtual NzFinanse NzpIdTechnicznyVatNavigation { get; set; } = null!;
}
