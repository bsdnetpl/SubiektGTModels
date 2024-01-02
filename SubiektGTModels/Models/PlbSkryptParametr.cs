using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSkryptParametr
{
    public int SkrpId { get; set; }

    public string SkrpKodOn { get; set; } = null!;

    public string SkrpKodIn { get; set; } = null!;

    public string SkrpKodIc { get; set; } = null!;

    public string SkrpReferencje { get; set; } = null!;

    public string SkrpUsing { get; set; } = null!;

    public int SkrpJezyk { get; set; }

    public byte[]? SkrpBinaria { get; set; }
}
