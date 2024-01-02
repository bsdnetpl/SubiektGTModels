using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmSendersList
{
    public int EslId { get; set; }

    public int EslUserId { get; set; }

    public int EslList { get; set; }

    public string EslEntry { get; set; } = null!;
}
