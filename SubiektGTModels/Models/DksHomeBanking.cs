using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DksHomeBanking
{
    public int HbId { get; set; }

    public string HbNazwa { get; set; } = null!;

    public byte[]? HbTransformacja { get; set; }
}
