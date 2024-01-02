using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpBlokadum
{
    public int EcpbId { get; set; }

    public int EcpbIdPrac { get; set; }

    public DateTime EcpbOd { get; set; }

    public DateTime EcpbDo { get; set; }

    public int EcpbIdObiektu { get; set; }

    public int EcpbRodzajObiektu { get; set; }

    public string EcpbOpisObiektu { get; set; } = null!;

    public virtual PrPracownik EcpbIdPracNavigation { get; set; } = null!;
}
