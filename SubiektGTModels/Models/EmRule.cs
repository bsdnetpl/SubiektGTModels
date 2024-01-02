using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmRule
{
    public int ErId { get; set; }

    public string ErName { get; set; } = null!;

    public int? ErGroupId { get; set; }

    public bool? ErMarkAsRead { get; set; }

    public int ErOperator { get; set; }

    public bool ErEnabled { get; set; }

    public int ErRank { get; set; }

    public bool ErFlag { get; set; }

    public int ErUserId { get; set; }

    public bool ErCheckSpamMark { get; set; }

    public int? ErMoveTo { get; set; }

    public int? ErFlagaWlasnaId { get; set; }

    public int? ErPriority { get; set; }

    public bool? ErPrivate { get; set; }

    public virtual ICollection<EmRuleWord> EmRuleWords { get; set; } = new List<EmRuleWord>();

    public virtual FlFlagi? ErFlagaWlasna { get; set; }
}
