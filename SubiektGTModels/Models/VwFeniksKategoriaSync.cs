using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksKategoriaSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string KatNazwa { get; set; } = null!;

    public string KatPodtytul { get; set; } = null!;
}
