using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsKlasyfikatory
{
    public int KskId { get; set; }

    public int KskTypObiektu { get; set; }

    public int KskIdSlownika { get; set; }

    public string KskNazwa { get; set; } = null!;

    public string KskOpis { get; set; } = null!;

    public int KskTryb { get; set; }

    public virtual ICollection<GrGrid> GrGrids { get; set; } = new List<GrGrid>();

    public virtual ICollection<KsKlasyfikatoryUklad> KsKlasyfikatoryUklads { get; set; } = new List<KsKlasyfikatoryUklad>();

    public virtual SlSlownik KskIdSlownikaNavigation { get; set; } = null!;

    public virtual GtObiekt KskTypObiektuNavigation { get; set; } = null!;
}
