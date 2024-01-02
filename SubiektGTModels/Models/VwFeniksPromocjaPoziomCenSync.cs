using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksPromocjaPoziomCenSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public int? PromotionFeniksId { get; set; }

    public int? PriceLevelFeniksId { get; set; }
}
