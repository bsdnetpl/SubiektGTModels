using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOddzialMagazyn
{
    public int SomId { get; set; }

    public int? SomIdOddzial { get; set; }

    public int SomIdMagazyn { get; set; }

    public virtual SlMagazyn SomIdMagazynNavigation { get; set; } = null!;

    public virtual SlOddzialy? SomIdOddzialNavigation { get; set; }
}
