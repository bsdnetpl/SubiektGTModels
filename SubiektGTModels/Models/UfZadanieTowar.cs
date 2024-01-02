using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfZadanieTowar
{
    public int UztIdZadanie { get; set; }

    public int UztIdTowar { get; set; }

    public virtual UfZadanie UztIdZadanieNavigation { get; set; } = null!;
}
