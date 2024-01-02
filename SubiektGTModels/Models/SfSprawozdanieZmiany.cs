using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfSprawozdanieZmiany
{
    public int SfszId { get; set; }

    public int SfszIdPole { get; set; }

    public DateTime? SfszWidoczneOd { get; set; }

    public DateTime? SfszWidoczneDo { get; set; }

    public virtual SfPole SfszIdPoleNavigation { get; set; } = null!;
}
