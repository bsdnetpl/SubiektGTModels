using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPkwiU
{
    public int PkwId { get; set; }

    public string PkwNumer { get; set; } = null!;

    public string PkwOpis { get; set; } = null!;

    public bool PkwOdwrotneObciazenie { get; set; }

    public int? PkwGtu { get; set; }
}
