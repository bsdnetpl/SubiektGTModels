using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RcpRejestrCzynnosciPrzetwarzaniaCele
{
    public int RcpcId { get; set; }

    public int RcpcIdRejestr { get; set; }

    public int RcpcIdCel { get; set; }

    public virtual CpCelPrzetwarzanium RcpcIdCelNavigation { get; set; } = null!;

    public virtual RcpRejestrCzynnosciPrzetwarzanium RcpcIdRejestrNavigation { get; set; } = null!;
}
