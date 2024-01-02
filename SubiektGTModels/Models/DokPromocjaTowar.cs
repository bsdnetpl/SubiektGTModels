using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokPromocjaTowar
{
    public int PctId { get; set; }

    public int PctIdPromocja { get; set; }

    public int PctIdTowaru { get; set; }

    public virtual DokPromocja PctIdPromocjaNavigation { get; set; } = null!;
}
