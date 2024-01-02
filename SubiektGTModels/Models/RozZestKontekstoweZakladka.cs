using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RozZestKontekstoweZakladka
{
    public int RozzkzId { get; set; }

    public int RozzkzIdZestKontekstowego { get; set; }

    public int RozzkzIdDefinicji { get; set; }

    public string RozzkzTytulZakladki { get; set; } = null!;

    public int RozzkzPozycja { get; set; }

    public virtual ZstEwid RozzkzIdDefinicjiNavigation { get; set; } = null!;

    public virtual RozZestKontekstowe RozzkzIdZestKontekstowegoNavigation { get; set; } = null!;
}
