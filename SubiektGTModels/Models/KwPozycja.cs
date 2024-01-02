using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KwPozycja
{
    public int KkwpId { get; set; }

    public int KkwpIdKarty { get; set; }

    public string? KkwpOpis { get; set; }

    public int? KkwpMpk { get; set; }

    public int? KkwpZlecenie { get; set; }

    public decimal KkwpWsp1 { get; set; }

    public decimal KkwpWsp2 { get; set; }

    public decimal KkwpWsp3 { get; set; }

    public decimal KkwpWsp4 { get; set; }

    public decimal KkwpWsp5 { get; set; }

    public decimal KkwpWsp6 { get; set; }

    public decimal KkwpWsp7 { get; set; }

    public decimal KkwpWsp8 { get; set; }

    public decimal KkwpWsp9 { get; set; }

    public decimal KkwpWsp10 { get; set; }

    public virtual KwKartum KkwpIdKartyNavigation { get; set; } = null!;

    public virtual StMpk? KkwpMpkNavigation { get; set; }

    public virtual ZlpZlecenie? KkwpZlecenieNavigation { get; set; }
}
