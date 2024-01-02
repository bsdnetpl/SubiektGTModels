using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbParser
{
    public int HbpId { get; set; }

    public string HbpOpis { get; set; } = null!;

    public int HbpInsStala { get; set; }

    public string? HbpProgId { get; set; }

    public int? HbpStronaKodowa { get; set; }
}
