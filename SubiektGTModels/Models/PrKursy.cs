using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrKursy
{
    public int PkuId { get; set; }

    public int PkuIdPracownika { get; set; }

    public string PkuNazwa { get; set; } = null!;

    public DateTime? PkuDataOd { get; set; }

    public DateTime? PkuDataDo { get; set; }

    public virtual PrPracownik PkuIdPracownikaNavigation { get; set; } = null!;
}
