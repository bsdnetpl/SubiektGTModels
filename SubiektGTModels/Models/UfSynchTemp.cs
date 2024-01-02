using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfSynchTemp
{
    public int UsytId { get; set; }

    public int UsytIdZadanie { get; set; }

    public int UsytIdTowar { get; set; }

    public string UsytTowarUf { get; set; } = null!;
}
