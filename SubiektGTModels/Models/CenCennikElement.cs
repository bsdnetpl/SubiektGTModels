using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CenCennikElement
{
    public int CeId { get; set; }

    public int CeIdSzablon { get; set; }

    public int CeIdElement { get; set; }

    public virtual CenCennikSzablon CeIdSzablonNavigation { get; set; } = null!;
}
