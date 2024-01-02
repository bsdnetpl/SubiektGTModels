using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StKst2016
{
    public int StkId { get; set; }

    public string StkNr { get; set; } = null!;

    public string StkNazwa { get; set; } = null!;

    public string StkOpis { get; set; } = null!;

    public virtual ICollection<StSrodekTrwaly> StSrodekTrwalies { get; set; } = new List<StSrodekTrwaly>();
}
