using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrPieczecKsiegowaPozycja
{
    public int DkppId { get; set; }

    public int DkppIdPieczeci { get; set; }

    public string DkppKonto { get; set; } = null!;

    public int DkppStrona { get; set; }

    public string DkppOpis { get; set; } = null!;

    public int DkppTypWiersza { get; set; }

    public int DkppPos { get; set; }

    public virtual DkrPieczecKsiegowa DkppIdPieczeciNavigation { get; set; } = null!;
}
