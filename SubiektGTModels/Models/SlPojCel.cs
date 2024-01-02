using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPojCel
{
    public int SpcId { get; set; }

    public string SpcCel { get; set; } = null!;

    public int? SpcIdTrasy { get; set; }

    public virtual ICollection<PojParametr> PojParametrs { get; set; } = new List<PojParametr>();

    public virtual SlPojTrasa? SpcIdTrasyNavigation { get; set; }
}
