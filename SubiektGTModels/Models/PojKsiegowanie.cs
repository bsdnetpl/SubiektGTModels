using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PojKsiegowanie
{
    public int PojkId { get; set; }

    public int PojkIdPojazdu { get; set; }

    public int PojkRok { get; set; }

    public int PojkMiesiac { get; set; }

    public decimal PojkWartosc { get; set; }

    public virtual PojPojazd PojkIdPojazduNavigation { get; set; } = null!;
}
