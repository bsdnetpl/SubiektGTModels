using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwNarzutTw
{
    public int CtId { get; set; }

    public int CtIdCena { get; set; }

    public int CtIdNarzut { get; set; }

    public int CtKolejnosc { get; set; }

    public decimal? CtNarzut { get; set; }

    public decimal? CtWartosc { get; set; }

    public virtual TwCena CtIdCenaNavigation { get; set; } = null!;
}
