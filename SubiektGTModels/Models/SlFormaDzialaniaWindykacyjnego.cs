using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlFormaDzialaniaWindykacyjnego
{
    public int FdwId { get; set; }

    public string? FdwNazwa { get; set; }

    public bool FdwPonaglenie { get; set; }

    public bool FdwSystemowa { get; set; }

    public virtual ICollection<ZwZdarzenieWindykacyjne> ZwZdarzenieWindykacyjnes { get; set; } = new List<ZwZdarzenieWindykacyjne>();
}
