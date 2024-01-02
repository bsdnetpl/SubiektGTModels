using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksJednostkaMiaryTwSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public string SymbolJednostki { get; set; } = null!;

    public decimal PrzelicznikJednostki { get; set; }

    public int? TowarMultistoreId { get; set; }

    public int? TowarSubiektId { get; set; }
}
