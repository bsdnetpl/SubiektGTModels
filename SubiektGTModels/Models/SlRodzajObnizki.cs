using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRodzajObnizki
{
    public int RobId { get; set; }

    public int RobNumer { get; set; }

    public string RobNazwa { get; set; } = null!;

    public virtual ICollection<PrzObnizkaPodatku> PrzObnizkaPodatkus { get; set; } = new List<PrzObnizkaPodatku>();
}
