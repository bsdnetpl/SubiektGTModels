using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSkladnikDefinicja
{
    public int SpdId { get; set; }

    public int SpdIdSkladnika { get; set; }

    public int? SpdIdSkladnikaNaUmowie { get; set; }

    public int SpdTypObiektu { get; set; }

    public DateTime? SpdDataOd { get; set; }

    public DateTime? SpdDataDo { get; set; }

    public int SpdTyp { get; set; }

    public string SpdSkrypt { get; set; } = null!;

    public string SpdOpis { get; set; } = null!;

    public decimal SpdWartosc { get; set; }

    public bool SpdOdZawsze { get; set; }

    public virtual PlbSkladnik SpdIdSkladnikaNavigation { get; set; } = null!;
}
