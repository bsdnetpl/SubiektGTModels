using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmArchive
{
    public int EarId { get; set; }

    public string EarUidl { get; set; } = null!;

    public int? EarAccountId { get; set; }
}
