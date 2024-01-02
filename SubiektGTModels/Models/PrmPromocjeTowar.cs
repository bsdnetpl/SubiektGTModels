using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeTowar
{
    public int PrmtId { get; set; }

    public int PrmtIdPromocja { get; set; }

    public int PrmtIdent { get; set; }

    public int PrmtTypIdent { get; set; }

    public virtual PrmPromocje PrmtIdPromocjaNavigation { get; set; } = null!;
}
