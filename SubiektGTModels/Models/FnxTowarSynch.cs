using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxTowarSynch
{
    public int MtId { get; set; }

    public int MtSubiektId { get; set; }

    public int? MtMultiStoreId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte MtStateId { get; set; }

    public int? MtHistoryMultiStoreId { get; set; }

    public DateTime? MtDimensionsChanged { get; set; }
}
