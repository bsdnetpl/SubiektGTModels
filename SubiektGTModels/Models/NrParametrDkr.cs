using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NrParametrDkr
{
    public int NpdIdRoku { get; set; }

    public bool NpdNrMiesiac { get; set; }

    public bool NpdNrRok { get; set; }

    public int NpdNrLuka { get; set; }

    public int NpdNrRodzaj { get; set; }

    public virtual PdRokObrotowy NpdIdRokuNavigation { get; set; } = null!;

    public virtual ICollection<NrNrStartDkr> NrNrStartDkrs { get; set; } = new List<NrNrStartDkr>();
}
