using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksPromocjaSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string PromotionSymbol { get; set; } = null!;

    public string? PromotionName { get; set; }

    public string PromotionDescription { get; set; } = null!;

    public DateTime? PromotionFrom { get; set; }

    public DateTime? PromotionTo { get; set; }

    public bool? PromotionForAllProducts { get; set; }

    public bool? PromotionForAllPriceLevels { get; set; }

    public decimal? PromotionPercentDiscount { get; set; }
}
