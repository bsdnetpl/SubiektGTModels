using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatPozycja
{
    public int PozId { get; set; }

    public int PozIdEwVat { get; set; }

    public string PozNazwa { get; set; } = null!;

    public decimal PozWartoscNetto { get; set; }

    public decimal PozWartoscBrutto { get; set; }

    public string PozOpis { get; set; } = null!;

    public virtual VatEwidVat PozIdEwVatNavigation { get; set; } = null!;
}
