using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlBadanieOkresowe
{
    public int BoId { get; set; }

    public string BoNazwa { get; set; } = null!;

    public virtual ICollection<PrBadaniaOkresowe> PrBadaniaOkresowes { get; set; } = new List<PrBadaniaOkresowe>();
}
