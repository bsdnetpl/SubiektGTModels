using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwDyspozycja
{
    public int IwdId { get; set; }

    public int IwdDoPozId { get; set; }

    public int IwdSpid { get; set; }

    public decimal IwdIlosc { get; set; }

    public DateTime IwdCzas { get; set; }

    public int? IwdDoId { get; set; }

    public decimal IwdDoIlosc { get; set; }

    public int? IwdIwRozbId { get; set; }

    public int IwdRealId { get; set; }
}
