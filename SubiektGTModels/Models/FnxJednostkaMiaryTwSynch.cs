using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxJednostkaMiaryTwSynch
{
    public int MtId { get; set; }

    public int MtSubiektId { get; set; }

    public int MtSubiektProductId { get; set; }

    public int? MtMultiStoreId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte MtStateId { get; set; }
}
