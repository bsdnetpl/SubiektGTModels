using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbSkojarzoneAutomatycznie
{
    public int HbIdTransakcji { get; set; }

    public int NzfId { get; set; }

    public int TypTransakcji { get; set; }

    public int TypOperacji { get; set; }

    public string HbNumerRachunku { get; set; } = null!;

    public DateTime? HbDataKsiegowania { get; set; }

    public DateTime NzfData { get; set; }

    public string? HbKodTranzakcji { get; set; }

    public string HbZnormalizowanyNumerRachunku { get; set; } = null!;
}
