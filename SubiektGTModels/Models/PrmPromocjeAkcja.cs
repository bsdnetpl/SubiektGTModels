using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeAkcja
{
    public int PrmaId { get; set; }

    public int PrmaIdPromocja { get; set; }

    public int PrmaIdent { get; set; }

    public int PrmaTypIdent { get; set; }

    public virtual PrmPromocje PrmaIdPromocjaNavigation { get; set; } = null!;
}
