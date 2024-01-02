using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PprAbsencja
{
    public int PpraId { get; set; }

    public int PpraIdWpisu { get; set; }

    public int PpraTypAbsencji { get; set; }

    public virtual PprPlanPracy PpraIdWpisuNavigation { get; set; } = null!;

    public virtual SlTypAbsencji PpraTypAbsencjiNavigation { get; set; } = null!;
}
