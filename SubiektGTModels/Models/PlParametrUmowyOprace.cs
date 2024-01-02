using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlParametrUmowyOprace
{
    public int PupId { get; set; }

    public int PupGenerowanyRaport { get; set; }

    public int PupKosztyUzyskania { get; set; }

    public int PupPrzelewNaKonto { get; set; }

    public decimal PupPrzelewKwota { get; set; }
}
