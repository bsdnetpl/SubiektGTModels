using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksPromocjaTowarSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public int? PromotionFeniksId { get; set; }

    public int? ProductFeniksId { get; set; }
}
