using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypAbsencji
{
    public int SltaId { get; set; }

    public string SltaNazwa { get; set; } = null!;

    public int SltaTypAbsencji { get; set; }

    public int SltaKolor { get; set; }

    public virtual ICollection<PprAbsencja> PprAbsencjas { get; set; } = new List<PprAbsencja>();
}
