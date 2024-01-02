using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatDaneVat
{
    public int DvId { get; set; }

    public int DvIdEwidVat { get; set; }

    public int DvTyp { get; set; }

    public int DvIdStawkiVat { get; set; }

    public decimal DvWartosc { get; set; }

    public decimal DvKwotaVat { get; set; }

    public decimal DvNetto { get; set; }

    public decimal DvBrutto { get; set; }

    public virtual VatEwidVat DvIdEwidVatNavigation { get; set; } = null!;

    public virtual SlStawkaVat DvIdStawkiVatNavigation { get; set; } = null!;
}
