using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrRezygnacjaPpk
{
    public int PpkrId { get; set; }

    public int PpkrIdPrac { get; set; }

    public DateTime PpkrDataDeklaracji { get; set; }

    public int PpkrStatus { get; set; }

    public DateTime? PpkrMiesiacZaprzestaniaNaliczaniaWplat { get; set; }

    public DateTime? PpkrMiesiacWznowieniaNaliczaniaWplat { get; set; }

    public int? PpkrIdDeklaracji { get; set; }

    public virtual DeklEwid? PpkrIdDeklaracjiNavigation { get; set; }

    public virtual PrPracownik PpkrIdPracNavigation { get; set; } = null!;
}
