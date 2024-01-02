using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWlasciwCechTw
{
    public int WctId { get; set; }

    public string WctNazwa { get; set; } = null!;

    public virtual ICollection<SlWlasciwoscCecha> SlWlasciwoscCechas { get; set; } = new List<SlWlasciwoscCecha>();
}
