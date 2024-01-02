using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class OssDaneVat
{
    public int OvId { get; set; }

    public int OvIdEwid { get; set; }

    public int OvIdStawkiVat { get; set; }

    public decimal? OvNettoPln { get; set; }

    public decimal? OvVatPln { get; set; }

    public decimal? OvBruttoPln { get; set; }

    public decimal? OvNettoEur { get; set; }

    public decimal? OvVatEur { get; set; }

    public decimal? OvBruttoEur { get; set; }

    public virtual OssEwid OvIdEw { get; set; } = null!;

    public virtual SlStawkaVat OvIdStawkiVatNavigation { get; set; } = null!;
}
