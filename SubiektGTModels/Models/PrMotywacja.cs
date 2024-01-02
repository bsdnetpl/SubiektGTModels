using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrMotywacja
{
    public int PmoId { get; set; }

    public int PmoIdPracownika { get; set; }

    public string PmoNazwa { get; set; } = null!;

    public DateTime? PmoDataOtrzymania { get; set; }

    public int? PmoRodzaj { get; set; }

    public virtual ICollection<BibDokument> BibDokuments { get; set; } = new List<BibDokument>();

    public virtual PrPracownik PmoIdPracownikaNavigation { get; set; } = null!;
}
