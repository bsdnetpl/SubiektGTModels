using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdBlokadaObiektGrupa
{
    public int BogrId { get; set; }

    public int BogrTypObiektu { get; set; }

    public int BogrTypObiektuEx { get; set; }

    public int BogrIdGrupy { get; set; }

    public virtual SlGrupaBlokadyObiektu BogrIdGrupyNavigation { get; set; } = null!;
}
