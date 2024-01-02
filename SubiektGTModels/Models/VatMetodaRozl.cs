using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatMetodaRozl
{
    public int MvId { get; set; }

    public int? MvRok { get; set; }

    public int? MvKwartal { get; set; }

    public int MvMetoda { get; set; }

    public int MvIdObiektu { get; set; }

    public bool MvMetodaKasowa { get; set; }

    public DateTime? MvPoczatek { get; set; }

    public int? MvIdPrzyczynaZwolnienia { get; set; }

    public virtual SlZwolnienieZvat? MvIdPrzyczynaZwolnieniaNavigation { get; set; }
}
