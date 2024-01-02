using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwpGtTransformacja
{
    public int GttId { get; set; }

    public int GttObiektId { get; set; }

    public string GttNazwa { get; set; } = null!;

    public int GttRodzajId { get; set; }

    public byte[]? GttTransformacja { get; set; }

    public string? GttSchemat { get; set; }

    public int? GttDefinicjaId { get; set; }

    public bool GttDomyslna { get; set; }
}
