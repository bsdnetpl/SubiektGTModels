using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokMagWart
{
    public int MwSeriaId { get; set; }

    public int MwPozId { get; set; }

    public DateTime MwData { get; set; }

    public decimal? MwCena { get; set; }
}
