using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrJezyki
{
    public int PjeId { get; set; }

    public int PjeIdPracownika { get; set; }

    public string PjeJezyk { get; set; } = null!;

    public string PjeStZnajomosci { get; set; } = null!;

    public virtual PrPracownik PjeIdPracownikaNavigation { get; set; } = null!;
}
