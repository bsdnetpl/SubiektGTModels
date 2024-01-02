using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzTypZdarzeniaWindykacyjnego
{
    public int WtId { get; set; }

    public string WtNazwa { get; set; } = null!;

    public bool WtPonaglenie { get; set; }

    public virtual ICollection<NzFinanseHistoriaWindykacji> NzFinanseHistoriaWindykacjis { get; set; } = new List<NzFinanseHistoriaWindykacji>();
}
