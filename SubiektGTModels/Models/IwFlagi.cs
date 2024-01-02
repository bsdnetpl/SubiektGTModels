using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwFlagi
{
    public int IwfId { get; set; }

    public int IwfIdFlagi { get; set; }

    public int IwfDoIwId { get; set; }

    public virtual IwDokument IwfDoIw { get; set; } = null!;

    public virtual FlFlagi IwfIdFlagiNavigation { get; set; } = null!;
}
