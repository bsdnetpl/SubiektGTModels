using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDeklZu
{
    public int DznId { get; set; }

    public bool DznWyslane { get; set; }

    public string DznTyp { get; set; } = null!;

    public DateTime? DznMiesiac { get; set; }

    public string? DznOpis { get; set; }

    public DateTime DznData { get; set; }

    public int? DznFormat { get; set; }
}
