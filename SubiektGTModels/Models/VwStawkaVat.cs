using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwStawkaVat
{
    public int VatId { get; set; }

    public string VatNazwa { get; set; } = null!;

    public decimal VatStawka { get; set; }

    public string VatSymbol { get; set; } = null!;

    public bool VatCzySystemowa { get; set; }

    public bool VatCzyWidoczna { get; set; }

    public int VatPozycja { get; set; }

    public int VatPozSprzedaz { get; set; }

    public int VatPozZakup { get; set; }

    public int VatPozRr { get; set; }

    public int VatPozDomyslna { get; set; }

    public int VatRodzaj { get; set; }

    public int? VatIdPanstwo { get; set; }

    public bool? VatUePanstwo { get; set; }
}
