using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlDystrybutor
{
    public int DyId { get; set; }

    public string DyNazwa { get; set; } = null!;

    public string DyMiejscowosc { get; set; } = null!;
}
