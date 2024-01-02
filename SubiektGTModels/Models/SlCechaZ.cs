using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCechaZ
{
    public int CzsId { get; set; }

    public string CzsNazwa { get; set; } = null!;

    public virtual ICollection<ZsCechaZ> ZsCechaZs { get; set; } = new List<ZsCechaZ>();
}
