using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZsRezerwacjaUczestnik
{
    public int ZsruId { get; set; }

    public int ZsruIdRezerwacji { get; set; }

    public int ZsruIdKlienta { get; set; }

    public virtual AdrEwid ZsruIdKlientaNavigation { get; set; } = null!;

    public virtual ZsRezerwacja ZsruIdRezerwacjiNavigation { get; set; } = null!;
}
