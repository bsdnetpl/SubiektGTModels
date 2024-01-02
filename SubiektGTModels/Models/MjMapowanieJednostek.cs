using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MjMapowanieJednostek
{
    public int MjId { get; set; }

    public string MjIdJednostki { get; set; } = null!;

    public int MjIdGrupy { get; set; }
}
