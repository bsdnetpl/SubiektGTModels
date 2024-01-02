using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokPromocjaKontrahent
{
    public int PckId { get; set; }

    public int PckIdPromocja { get; set; }

    public int PckIdKontrahent { get; set; }

    public virtual DokPromocja PckIdPromocjaNavigation { get; set; } = null!;
}
