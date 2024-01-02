using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlDzial
{
    public int DziId { get; set; }

    public string DziNazwa { get; set; } = null!;

    public virtual ICollection<PlbUmowaCp> PlbUmowaCps { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PlbUmowaDzialStanowisko> PlbUmowaDzialStanowiskos { get; set; } = new List<PlbUmowaDzialStanowisko>();
}
