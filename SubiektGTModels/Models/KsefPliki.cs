using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefPliki
{
    public int KsefxId { get; set; }

    public string KsefxXml { get; set; } = null!;

    public string? KsefxHash { get; set; }

    public virtual ICollection<KsefFaktury> KsefFakturies { get; set; } = new List<KsefFaktury>();
}
