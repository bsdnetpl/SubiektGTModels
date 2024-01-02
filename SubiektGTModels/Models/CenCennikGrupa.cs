using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CenCennikGrupa
{
    public int CgrId { get; set; }

    public int CgrIdSzablon { get; set; }

    public int CgrIdGrupa { get; set; }

    public virtual SlGrupaTw CgrIdGrupaNavigation { get; set; } = null!;

    public virtual CenCennikSzablon CgrIdSzablonNavigation { get; set; } = null!;
}
