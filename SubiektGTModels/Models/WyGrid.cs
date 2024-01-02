using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyGrid
{
    public int WgrId { get; set; }

    public string WgrGridId { get; set; } = null!;

    public int WgrUserId { get; set; }

    public byte[] WgrParametry { get; set; } = null!;

    public int WgrService { get; set; }
}
