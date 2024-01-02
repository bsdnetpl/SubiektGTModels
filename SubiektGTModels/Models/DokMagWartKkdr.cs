using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokMagWartKkdr
{
    public int MwkkdSeriaId { get; set; }

    public int MwkkdPozId { get; set; }

    public DateTime MwkkdData { get; set; }

    public decimal MwkkdDelta { get; set; }

    public virtual DokPozycja MwkkdPoz { get; set; } = null!;
}
