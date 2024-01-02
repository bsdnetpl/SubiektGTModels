using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikPodstawa
{
    public int PwpId { get; set; }

    public int PwpIdWspolnika { get; set; }

    public int PwpTyp { get; set; }

    public DateTime? PwpDataOd { get; set; }

    public decimal PwpWartosc { get; set; }

    public virtual PdWspolnik PwpIdWspolnikaNavigation { get; set; } = null!;
}
