using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwKodKreskowy
{
    public int KkId { get; set; }

    public int KkIdTowar { get; set; }

    public string KkKod { get; set; } = null!;

    public decimal? KkIlosc { get; set; }

    public virtual TwTowar KkIdTowarNavigation { get; set; } = null!;
}
