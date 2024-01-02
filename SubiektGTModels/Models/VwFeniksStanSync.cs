using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksStanSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public int MtSubiektWarehouseId { get; set; }

    public int MtSubiektProductId { get; set; }

    public byte StateId { get; set; }

    public decimal? StStan { get; set; }

    public int? MtMultiStoreWarehouseId { get; set; }

    public int? MtMultiStoreTowarId { get; set; }
}
