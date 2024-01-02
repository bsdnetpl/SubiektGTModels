using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksSlRabatSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string? NazwaRabatu { get; set; }

    public decimal? ProcentRabatu { get; set; }
}
