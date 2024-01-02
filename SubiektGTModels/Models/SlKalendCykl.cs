using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendCykl
{
    public int SlcId { get; set; }

    public int SlcIdKalend { get; set; }

    public DateTime SlcOd { get; set; }

    public virtual SlKalendarz SlcIdKalendNavigation { get; set; } = null!;
}
