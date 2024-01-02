using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZstSubRejVatMarza
{
    public int? VatId { get; set; }

    public int? DokId { get; set; }

    public decimal? NettoMarza { get; set; }

    public decimal? VatMarza { get; set; }

    public decimal? BruttoMarza { get; set; }
}
