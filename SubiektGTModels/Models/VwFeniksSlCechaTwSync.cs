using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksSlCechaTwSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string CtwNazwa { get; set; } = null!;
}
