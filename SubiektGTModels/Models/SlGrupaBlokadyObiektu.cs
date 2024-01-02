using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaBlokadyObiektu
{
    public int GrbloId { get; set; }

    public string GrbloNazwa { get; set; } = null!;

    public virtual ICollection<PdBlokadaObiektGrupa> PdBlokadaObiektGrupas { get; set; } = new List<PdBlokadaObiektGrupa>();
}
