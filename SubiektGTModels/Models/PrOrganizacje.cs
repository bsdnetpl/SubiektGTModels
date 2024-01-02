using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrOrganizacje
{
    public int PorId { get; set; }

    public int PorIdPracownika { get; set; }

    public string PorNazwa { get; set; } = null!;

    public string PorFunkcja { get; set; } = null!;

    public DateTime? PorDataOd { get; set; }

    public DateTime? PorDataDo { get; set; }

    public virtual PrPracownik PorIdPracownikaNavigation { get; set; } = null!;
}
