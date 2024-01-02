using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWalutaNominal
{
    public int WlnId { get; set; }

    public int WlnIdWaluty { get; set; }

    public decimal WlnNominal { get; set; }

    public string WlnOpis { get; set; } = null!;

    public int WlnPozycja { get; set; }

    public virtual SlWalutum WlnIdWalutyNavigation { get; set; } = null!;
}
