using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfSynchroKodyKresk
{
    public int UskId { get; set; }

    public int UskIdSynchronizacja { get; set; }

    public string UskKod { get; set; } = null!;

    public virtual UfSynchronizacja UskIdSynchronizacjaNavigation { get; set; } = null!;
}
