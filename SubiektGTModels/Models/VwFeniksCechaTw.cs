using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksCechaTw
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public int? ProductMultiStoreId { get; set; }

    public int? ProductAttributeMultiStoreId { get; set; }

    public int? FeniksFeatureKeyId { get; set; }
}
