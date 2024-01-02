using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokFunduszPromocji
{
    public int DfpId { get; set; }

    public int DfpDokId { get; set; }

    public int DfpFundId { get; set; }

    public string DfpFundNazwa { get; set; } = null!;

    public decimal DfpWartosc { get; set; }

    public decimal? DfpPodstawaJm { get; set; }

    public decimal? DfpPodstawaNetto { get; set; }
}
