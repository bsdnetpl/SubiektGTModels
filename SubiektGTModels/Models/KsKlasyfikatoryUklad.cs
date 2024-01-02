using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsKlasyfikatoryUklad
{
    public int KsuId { get; set; }

    public int? KsuIdRodzica { get; set; }

    public int? KsuIdKlasyfikacji { get; set; }

    public int KsuPozycja { get; set; }

    public string KsuNazwa { get; set; } = null!;

    public bool KsuRozwinieta { get; set; }

    public int KsuIdWpisu { get; set; }

    public virtual KsKlasyfikatory? KsuIdKlasyfikacjiNavigation { get; set; }
}
