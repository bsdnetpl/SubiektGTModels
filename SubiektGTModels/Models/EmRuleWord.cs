using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmRuleWord
{
    public int EwId { get; set; }

    public int EwRuleId { get; set; }

    public int EwField { get; set; }

    public string EwWord { get; set; } = null!;

    public virtual EmRule EwRule { get; set; } = null!;
}
