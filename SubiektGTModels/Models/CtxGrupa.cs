using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CtxGrupa
{
    public int CtgId { get; set; }

    public string CtgNazwa { get; set; } = null!;

    public string CtgSql { get; set; } = null!;

    public byte[] CtgDef { get; set; } = null!;
}
