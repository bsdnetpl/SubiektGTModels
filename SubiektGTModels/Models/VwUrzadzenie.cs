using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwUrzadzenie
{
    public int UurId { get; set; }

    public int UurIdSterownik { get; set; }

    public string UurNazwa { get; set; } = null!;

    public int UurOperacje { get; set; }

    public int UurTowarUf { get; set; }

    public string? UurModel { get; set; }
}
