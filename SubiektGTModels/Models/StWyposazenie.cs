using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StWyposazenie
{
    public int WpsId { get; set; }

    public string WpsNazwa { get; set; } = null!;

    public DateTime WpsDataNabycia { get; set; }

    public decimal WpsWartosc { get; set; }

    public string WpsDokNabycia { get; set; } = null!;

    public string WpsNrInw { get; set; } = null!;

    public string? WpsNrPozycji { get; set; }

    public bool WpsCzyZlikwidowany { get; set; }

    public DateTime? WpsDataLikwidacji { get; set; }

    public string? WpsPrzyczyna { get; set; }

    public string? WpsUwagi { get; set; }
}
