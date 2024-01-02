using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeMagazyn
{
    public int PrmmId { get; set; }

    public int PrmmIdPromocja { get; set; }

    public int PrmmIdent { get; set; }

    public virtual PrmPromocje PrmmIdPromocjaNavigation { get; set; } = null!;

    public virtual SlMagazyn PrmmIdentNavigation { get; set; } = null!;
}
