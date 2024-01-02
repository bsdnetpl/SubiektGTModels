using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrUlgi
{
    public int PuId { get; set; }

    public int PuIdPracownika { get; set; }

    public int PuRodzajUlgi { get; set; }

    public DateTime PuUlgaOd { get; set; }

    public DateTime PuUlgaDo { get; set; }

    public virtual PrPracownik PuIdPracownikaNavigation { get; set; } = null!;
}
