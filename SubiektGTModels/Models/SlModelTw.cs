using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlModelTw
{
    public int MdtId { get; set; }

    public string MdtNazwa { get; set; } = null!;

    public virtual ICollection<SlModelTowar> SlModelTowars { get; set; } = new List<SlModelTowar>();
}
