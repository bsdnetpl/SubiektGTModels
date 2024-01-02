using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGratAtrybutGodzinDni
{
    public int AgdId { get; set; }

    public string AgdNazwa { get; set; } = null!;

    public decimal AgdWspolczynnik { get; set; }
}
