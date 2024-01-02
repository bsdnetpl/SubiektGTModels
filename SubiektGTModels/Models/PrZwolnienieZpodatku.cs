using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrZwolnienieZpodatku
{
    public int PrzzpId { get; set; }

    public int PrzzpPracownik { get; set; }

    public DateTime PrzzpDataOd { get; set; }

    public DateTime PrzzpDataDo { get; set; }

    public virtual PrPracownik PrzzpPracownikNavigation { get; set; } = null!;
}
