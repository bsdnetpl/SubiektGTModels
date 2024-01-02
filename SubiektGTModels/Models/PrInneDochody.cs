using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrInneDochody
{
    public int PidId { get; set; }

    public int PidIdPracownika { get; set; }

    public DateTime PidDataWpisu { get; set; }

    public string PidOpis { get; set; } = null!;

    public int PidRok { get; set; }

    public decimal PidKwota { get; set; }

    public int PidTyp { get; set; }

    public int PidMiesiac { get; set; }

    public virtual PrPracownik PidIdPracownikaNavigation { get; set; } = null!;
}
