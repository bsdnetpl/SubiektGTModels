using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwAplogPod
{
    public int AlId { get; set; }

    public int? AlIdAp { get; set; }

    public int AlWynik { get; set; }

    public string? ApNazwa { get; set; }

    public string AlNrDekretu { get; set; } = null!;

    public string AlNazwaUzytkownika { get; set; } = null!;

    public DateTime AlDataUruchomienia { get; set; }

    public DateTime AlOkresOd { get; set; }

    public DateTime AlOkresDo { get; set; }

    public string? AlLog { get; set; }
}
