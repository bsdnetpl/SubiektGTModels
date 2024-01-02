using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbPracownikZespol
{
    public int PlbpzId { get; set; }

    public int PlbpzIdPracownika { get; set; }

    public int PlbpzIdZespolu { get; set; }

    public virtual PrPracownik PlbpzIdPracownikaNavigation { get; set; } = null!;

    public virtual SlZespolPrac PlbpzIdZespoluNavigation { get; set; } = null!;
}
