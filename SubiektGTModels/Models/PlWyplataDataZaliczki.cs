using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlWyplataDataZaliczki
{
    public int WdzId { get; set; }

    public int WdzIdPracownika { get; set; }

    public int WdzRok { get; set; }

    public int WdzMiesiac { get; set; }

    public DateTime? WdzData { get; set; }

    public virtual PrPracownik WdzIdPracownikaNavigation { get; set; } = null!;
}
