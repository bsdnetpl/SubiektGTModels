using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikGrupaKh
{
    public int IcenkgId { get; set; }

    public int IcenkgCennikId { get; set; }

    public int IcenkgGrupaId { get; set; }

    public virtual IcenCennikiIndywidualne IcenkgCennik { get; set; } = null!;

    public virtual SlGrupaKh IcenkgGrupa { get; set; } = null!;
}
