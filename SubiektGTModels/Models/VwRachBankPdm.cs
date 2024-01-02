using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRachBankPdm
{
    public int RbId { get; set; }

    public string RbNazwa { get; set; } = null!;

    public string RbNumer { get; set; } = null!;

    public string RbBank { get; set; } = null!;

    public bool RbPodstawowy { get; set; }

    public bool RbEbank { get; set; }

    public bool RbZfss { get; set; }

    public bool RbUs { get; set; }

    public string? RbAnalityka { get; set; }
}
