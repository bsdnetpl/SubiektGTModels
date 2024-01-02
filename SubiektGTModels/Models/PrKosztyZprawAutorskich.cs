using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrKosztyZprawAutorskich
{
    public int PkaId { get; set; }

    public int PkaIdPracownika { get; set; }

    public DateTime PkaDataWpisu { get; set; }

    public string PkaOpis { get; set; } = null!;

    public int PkaRok { get; set; }

    public decimal PkaKwota { get; set; }

    public virtual PrPracownik PkaIdPracownikaNavigation { get; set; } = null!;
}
