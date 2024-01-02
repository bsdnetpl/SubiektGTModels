using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklParametr
{
    public int DprId { get; set; }

    public int DprPodpis { get; set; }

    public int DprSposobWykazywaniaKwotyVatdeklViudo { get; set; }

    public int DprAutomatycznePrzeliczaniePolZalacznikow { get; set; }
}
