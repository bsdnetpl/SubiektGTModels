using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanseNotaPozycja
{
    public int NztId { get; set; }

    public DateTime? NztDataOd { get; set; }

    public DateTime? NztDataDo { get; set; }

    public decimal? NztWartoscRozrachunku { get; set; }

    public int? NztLiczbaDni { get; set; }

    public decimal? NztStopa { get; set; }

    public decimal? NztOdsetki { get; set; }

    public int? NztIdNoty { get; set; }

    public virtual NzFinanse? NztIdNotyNavigation { get; set; }
}
