using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlObywatelstwo
{
    public int ObwId { get; set; }

    public string ObwNazwa { get; set; } = null!;

    public int? ObwIdPanstwa { get; set; }

    public virtual SlPanstwo? ObwIdPanstwaNavigation { get; set; }

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
