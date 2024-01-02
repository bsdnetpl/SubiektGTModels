using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrKursyBhp
{
    public int PbhpId { get; set; }

    public int PbhpIdPracownika { get; set; }

    public int PbhpIdKursu { get; set; }

    public DateTime PbhpDataOdbycia { get; set; }

    public DateTime PbhpDataWaznosci { get; set; }

    public virtual SlKursBhp PbhpIdKursuNavigation { get; set; } = null!;

    public virtual PrPracownik PbhpIdPracownikaNavigation { get; set; } = null!;
}
