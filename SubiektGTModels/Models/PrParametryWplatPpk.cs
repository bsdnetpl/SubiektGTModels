using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrParametryWplatPpk
{
    public int PpId { get; set; }

    public int PpIdPrac { get; set; }

    public int PpTyp { get; set; }

    public DateTime PpDataDeklaracji { get; set; }

    public DateTime PpMiesiacOd { get; set; }

    public decimal PpWartosc { get; set; }

    public int? PpIdDeklaracji { get; set; }

    public virtual DeklEwid? PpIdDeklaracjiNavigation { get; set; }

    public virtual PrPracownik PpIdPracNavigation { get; set; } = null!;
}
