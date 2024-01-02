using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklDeklViudo
{
    public int DdvId { get; set; }

    public int DdvIdDeklaracji { get; set; }

    public byte[]? DdvXml { get; set; }

    public virtual DeklEwid DdvIdDeklaracjiNavigation { get; set; } = null!;
}
