using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPracaSzczegolnyCharakter
{
    public int PchId { get; set; }

    public string PchTresc { get; set; } = null!;

    public string PchKod { get; set; } = null!;

    public virtual ICollection<PlbUmowaDzialStanowisko> PlbUmowaDzialStanowiskos { get; set; } = new List<PlbUmowaDzialStanowisko>();
}
