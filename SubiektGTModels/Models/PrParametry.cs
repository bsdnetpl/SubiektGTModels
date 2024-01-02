using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrParametry
{
    public int PrhId { get; set; }

    public int PrhIdPracownika { get; set; }

    public DateTime? PrhWazneOd { get; set; }

    public DateTime? PrhWazneDo { get; set; }

    public string PrhKlucz { get; set; } = null!;

    public int PrhWartosc { get; set; }

    public int PrhTryb { get; set; }

    public virtual PrPracownik PrhIdPracownikaNavigation { get; set; } = null!;
}
