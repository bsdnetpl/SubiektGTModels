using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikMagazyn
{
    public int IcenmId { get; set; }

    public int IcenmCennikId { get; set; }

    public int IcenmMagId { get; set; }

    public virtual IcenCennikiIndywidualne IcenmCennik { get; set; } = null!;

    public virtual SlMagazyn IcenmMag { get; set; } = null!;
}
