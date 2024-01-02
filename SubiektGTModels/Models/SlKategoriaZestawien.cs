using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKategoriaZestawien
{
    public int KzId { get; set; }

    public string KzNazwa { get; set; } = null!;

    public int KzIkona { get; set; }

    public virtual ICollection<ZstEwid> ZstEwids { get; set; } = new List<ZstEwid>();
}
