using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRodzajOdliczenium
{
    public int RodId { get; set; }

    public int RodNumer { get; set; }

    public string RodNazwa { get; set; } = null!;

    public virtual ICollection<PrzOdliczenieDoliczenie> PrzOdliczenieDoliczenies { get; set; } = new List<PrzOdliczenieDoliczenie>();
}
