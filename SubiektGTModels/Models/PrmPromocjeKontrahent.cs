using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeKontrahent
{
    public int PrmkId { get; set; }

    public int PrmkIdPromocja { get; set; }

    public int PrmkIdent { get; set; }

    public int PrmkTypIdent { get; set; }

    public virtual PrmPromocje PrmkIdPromocjaNavigation { get; set; } = null!;
}
