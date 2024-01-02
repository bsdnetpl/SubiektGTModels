using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyStatusWydruku
{
    public int WysId { get; set; }

    public int WysIdObiektu { get; set; }

    public int WysTypObiektu { get; set; }

    public DateTime WysDataWydruku { get; set; }

    public int WysStatus { get; set; }
}
