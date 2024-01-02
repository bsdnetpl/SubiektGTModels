using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDatyBlokad
{
    public int BlId { get; set; }

    public DateTime? BlBlokadaSubiekt { get; set; }

    public DateTime? BlBlokadaRew { get; set; }

    public int BlParamEwidId { get; set; }
}
