using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypObecnosci
{
    public int SltoId { get; set; }

    public string SltoNazwa { get; set; } = null!;

    public string? SltoOpis { get; set; }

    public int SltoKolor { get; set; }

    public int? SltoAtrybutGodziny { get; set; }

    public int SltoOd { get; set; }

    public int SltoDo { get; set; }

    public virtual SlAtrybutGodzinowy? SltoAtrybutGodzinyNavigation { get; set; }
}
