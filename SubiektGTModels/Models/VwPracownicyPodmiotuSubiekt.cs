using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPracownicyPodmiotuSubiekt
{
    public int MagId { get; set; }

    public int UzId { get; set; }

    public string UzNazwisko { get; set; } = null!;

    public string UzImie { get; set; } = null!;

    public string? UzNazwiskoImie { get; set; }

    public string? UzImieNazwisko { get; set; }
}
