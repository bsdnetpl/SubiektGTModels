using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatProporcjaBazowa
{
    public int VpbId { get; set; }

    public int VpbRok { get; set; }

    public decimal VpbOpn { get; set; }

    public decimal VpbOz { get; set; }

    public decimal VpbSd { get; set; }

    public decimal VpbWartosc { get; set; }

    public decimal VpbWartoscDoDeklaracji { get; set; }

    public DateTime? VpbOkresOd { get; set; }

    public DateTime? VpbOkresDo { get; set; }

    public decimal VpbWartoscPreproporcja { get; set; }
}
