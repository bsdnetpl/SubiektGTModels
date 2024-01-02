using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseNumeracja
{
    public int NzfId { get; set; }

    public int? NzfNumer { get; set; }

    public DateTime NzfData { get; set; }

    public int? NzfIdKasy { get; set; }

    public int? NzfTyp { get; set; }
}
