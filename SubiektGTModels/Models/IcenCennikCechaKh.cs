using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikCechaKh
{
    public int IcenkcId { get; set; }

    public int IcenkcCennikId { get; set; }

    public int IcenkcCechaId { get; set; }

    public virtual SlCechaKh IcenkcCecha { get; set; } = null!;

    public virtual IcenCennikiIndywidualne IcenkcCennik { get; set; } = null!;
}
