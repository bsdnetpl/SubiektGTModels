using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class OssPozycja
{
    public int OepId { get; set; }

    public int OepIdEwVat { get; set; }

    public string OepNazwa { get; set; } = null!;

    public decimal OepIlosc { get; set; }

    public string? OepJednostkaMiary { get; set; }

    public decimal OepWartoscNetto { get; set; }

    public virtual OssEwid OepIdEwVatNavigation { get; set; } = null!;
}
