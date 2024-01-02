using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmGrupaWiadomosci
{
    public int GwaId { get; set; }

    public string GwaNazwa { get; set; } = null!;

    public virtual ICollection<EmEmail> EmEmails { get; set; } = new List<EmEmail>();

    public virtual ICollection<EmTemplate> EmTemplates { get; set; } = new List<EmTemplate>();
}
