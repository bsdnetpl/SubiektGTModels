using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ApLog
{
    public int AlId { get; set; }

    public int AlWynik { get; set; }

    public int? AlIdAp { get; set; }

    public int? AlIdUzytkownika { get; set; }

    public string AlNazwaUzytkownika { get; set; } = null!;

    public DateTime AlDataUruchomienia { get; set; }

    public DateTime AlOkresOd { get; set; }

    public DateTime AlOkresDo { get; set; }

    public string? AlLog { get; set; }

    public string AlNrDekretu { get; set; } = null!;

    public virtual ApAp? AlIdApNavigation { get; set; }

    public virtual PdUzytkownik? AlIdUzytkownikaNavigation { get; set; }

    public virtual ICollection<ApLogOpi> ApLogOpis { get; set; } = new List<ApLogOpi>();
}
