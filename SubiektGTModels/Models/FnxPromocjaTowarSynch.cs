using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxPromocjaTowarSynch
{
    public int MtId { get; set; }

    public int MtSubiektPromocjaId { get; set; }

    public int MtSubiektTowarId { get; set; }

    public int? MtMultiStoreId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte MtStateId { get; set; }
}
