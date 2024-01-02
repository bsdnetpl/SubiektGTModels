using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmSignature
{
    public int EsId { get; set; }

    public int EsUserId { get; set; }

    public int EsAccountId { get; set; }

    public string? EsText { get; set; }

    public string? EsMht { get; set; }

    public int EsPosition { get; set; }
}
