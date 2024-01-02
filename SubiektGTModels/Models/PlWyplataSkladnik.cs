using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlWyplataSkladnik
{
    public int WypsId { get; set; }

    public int WypsIdWzorca { get; set; }

    public int WypsIdWyplaty { get; set; }

    public string? WypsNazwa { get; set; }

    public decimal WypsWartosc { get; set; }

    public decimal? WypsParametr { get; set; }

    public virtual PlWyplatum WypsIdWyplatyNavigation { get; set; } = null!;

    public virtual SlWzorzecSkladnikaPlacowego WypsIdWzorcaNavigation { get; set; } = null!;
}
