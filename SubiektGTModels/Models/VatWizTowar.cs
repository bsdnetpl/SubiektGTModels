using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatWizTowar
{
    public int VwtwId { get; set; }

    public int VwtwWersja { get; set; }

    public int VwtwLiczbaUruchom { get; set; }

    public int VwtwIdVatSpOld { get; set; }

    public int VwtwIdVatSpNew { get; set; }

    public int VwtwIdVatZakOld { get; set; }

    public int VwtwIdVatZakNew { get; set; }

    public bool VwtwBlokadaSpr { get; set; }

    public bool VwtwBlokadaZak { get; set; }

    public DateTime VwtwData { get; set; }
}
