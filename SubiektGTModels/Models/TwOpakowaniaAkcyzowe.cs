using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwOpakowaniaAkcyzowe
{
    public int TwoaId { get; set; }

    public int TwoaIdTowaru { get; set; }

    public int TwoaIdKoduOpakowania { get; set; }

    public virtual SlKodRodzajuOpakowanTwAkcyzowych TwoaIdKoduOpakowaniaNavigation { get; set; } = null!;

    public virtual TwTowar TwoaIdTowaruNavigation { get; set; } = null!;
}
