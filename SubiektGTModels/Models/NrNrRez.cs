using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NrNrRez
{
    public int RezId { get; set; }

    public int? RezRejId { get; set; }

    public int RezTyp { get; set; }

    public string? RezRoz { get; set; }

    public DateTime RezDataWyst { get; set; }

    public int RezNr { get; set; }

    public int? RezDefiniowalnyId { get; set; }
}
