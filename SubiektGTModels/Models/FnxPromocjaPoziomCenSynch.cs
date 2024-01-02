using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxPromocjaPoziomCenSynch
{
    public int MtId { get; set; }

    public int MtSubiektPromocjaId { get; set; }

    public int MtSubiektPoziomCenId { get; set; }

    public int? MtMultiStoreId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte MtStateId { get; set; }
}
