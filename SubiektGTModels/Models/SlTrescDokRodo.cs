using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTrescDokRodo
{
    public int TdId { get; set; }

    public bool TdDomyslna { get; set; }

    public string TdOpis { get; set; } = null!;

    public int TdTypDokumentu { get; set; }

    public byte[]? TdTresc { get; set; }
}
