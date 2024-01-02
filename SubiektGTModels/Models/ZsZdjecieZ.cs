using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZsZdjecieZ
{
    public int ZdjId { get; set; }

    public int ZdjIdZasob { get; set; }

    public byte[]? ZdjZdjecie { get; set; }

    public bool ZdjGlowne { get; set; }

    public virtual ZsZasob ZdjIdZasobNavigation { get; set; } = null!;
}
