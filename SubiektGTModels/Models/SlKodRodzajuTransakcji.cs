using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodRodzajuTransakcji
{
    public int KrtKod { get; set; }

    public string KrtNazwa { get; set; } = null!;

    public bool KrtAktywny { get; set; }

    public DateOnly? KrtOkresDo { get; set; }
}
