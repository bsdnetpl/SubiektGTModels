using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodSwiadczenium
{
    public int KswId { get; set; }

    public string KswKod { get; set; } = null!;

    public string KswOpis { get; set; } = null!;

    public virtual ICollection<PdWspolnikSwiadczenie> PdWspolnikSwiadczenies { get; set; } = new List<PdWspolnikSwiadczenie>();
}
