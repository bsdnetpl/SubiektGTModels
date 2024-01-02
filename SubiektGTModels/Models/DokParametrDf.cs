using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokParametrDf
{
    public int DkdTyp { get; set; }

    public int DkdPodtyp { get; set; }

    public int? DkdDrukarkaId { get; set; }

    public string? DkdKomputer { get; set; }

    public int? DkdParamEwidId { get; set; }

    public int DkdDefiniowalnyId { get; set; }
}
